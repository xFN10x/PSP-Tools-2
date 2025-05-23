using System.Diagnostics;
using System.Text;
using PSP_Tools_2.SfoClasses;

namespace PSP_Tools_2
{
    internal class SFOReader
    {
        // header varibles
        public string MAGIC;
        public string VERSION;
        public UInt32 KEY_TABLE_OFFSET;
        public UInt32 DATA_TABLE_OFFSET;
        public UInt32 ENTRIES;

        public SfoDataEntry DefaultData = new(Encoding.UTF8.GetBytes("Data"), "Data key", SfoDataFormat.SFOFormat.utf8, 128, 128);

        // index table varibles
        public List<SfoIndexEntry> INDEXS = [];

        // other tables
        public List<SfoDataEntry> Data = [];

        private static void Print(String Strings)
        {
            //foreach (var item in Strings)
            //{
            Debug.WriteLine(Strings);
            //}
        }

        public static string Format(string String)
        {
            return String.Trim().Replace(Convert.ToChar(0x0).ToString(), "");
        }

        public object GetFromKey(string key)
        {
            foreach (var item in Data)
            {
                if (Format(key).Contains(Format(item.Key)))
                {
                    return item.ReadData();
                }
                else
                {
                    Debug.WriteLine(" ");
                    Debug.WriteLine(key.Trim().Replace(Convert.ToChar(0x0).ToString(), ""));
                    Debug.WriteLine("is not");
                    Debug.WriteLine(item.Key.Trim().Replace(Convert.ToChar(0x0).ToString(), ""));
                    Debug.WriteLine(" ");
                    continue;
                }
            }
            return DefaultData.ReadData();
        }

        public SFOReader(String file)
        {
            var bytes = File.ReadAllBytes(file);

            // Read Header
            MAGIC = System.Text.Encoding.UTF8.GetString(PSPTools.SubArray<byte>(bytes, 0, 4));
            VERSION = "1.01";
            KEY_TABLE_OFFSET = BitConverter.ToUInt32(bytes, 8);
            DATA_TABLE_OFFSET = BitConverter.ToUInt32(bytes, 12);
            ENTRIES = BitConverter.ToUInt32(bytes, 16);
            Print(MAGIC);
            Print(VERSION);
            Print(KEY_TABLE_OFFSET.ToString());
            Print(DATA_TABLE_OFFSET.ToString());
            Print(ENTRIES.ToString());

            // Read Index Table
            int keyOff = 0;
            for (int i = 0; i < ENTRIES; i++)
            {
                var index = new SfoIndexEntry(
                    BitConverter.ToUInt16(bytes, 20 + keyOff),
                    PSPTools.SubArray<byte>(bytes, 22 + keyOff, 2),
                    BitConverter.ToUInt32(bytes, 24 + keyOff),
                    BitConverter.ToUInt32(bytes, 28 + keyOff),
                    BitConverter.ToUInt32(bytes, 32 + keyOff)
                    );
                INDEXS.Add(index);
                keyOff += 16;
                //Print(index.GetDebugString());
            }

            // Read Data
            foreach (var item in INDEXS)
            {
                var i = INDEXS.IndexOf(item);
                string key;

                // Get the Key name
                if (i + 1 >= 0 && i + 1 < INDEXS.Count)
                {
                    key = System.Text.Encoding.UTF8.GetString(PSPTools.SubArray<byte>(
                    bytes,
                    Convert.ToInt32(KEY_TABLE_OFFSET + item.KeyOffset),
                    INDEXS[i + 1].KeyOffset - item.KeyOffset));
                }
                else if (i < INDEXS.Count)
                {
                    Debug.WriteLine(Convert.ToInt32(DATA_TABLE_OFFSET));
                    key = System.Text.Encoding.UTF8.GetString(PSPTools.SubArray<byte>(
                    bytes,
                    Convert.ToInt32(KEY_TABLE_OFFSET + item.KeyOffset),
                    Convert.ToInt32(DATA_TABLE_OFFSET - (KEY_TABLE_OFFSET + item.KeyOffset))));
                }
                else key = "ERROR!";

                // Get the data bytes
                var data = PSPTools.SubArray<byte>(bytes,
                    Convert.ToInt32(DATA_TABLE_OFFSET + item.DataOffset),
                    Convert.ToInt32(item.DataMaxLength)
                    );

                // Construct the data entry.
                SfoDataEntry entry = new(data, key, item.Format.Format, item.DataLength, item.DataMaxLength);
                Data.Add(entry);

                //var dataType = SfoDataEntry.TypeFromFormat(item.Format.Format);
                //var readData = entry.ReadData(item.Format.Format);
                //MessageBox.Show($"key: {entry.Key}");
                //MessageBox.Show($" data: {entry.ReadData()}");
            }
        }
    }
}
