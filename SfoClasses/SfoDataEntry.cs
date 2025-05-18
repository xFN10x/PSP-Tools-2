using static PSP_Tools_2.SfoClasses.SfoDataFormat;

namespace PSP_Tools_2.SfoClasses
{
    internal class SfoDataEntry(byte[] data, string key, SFOFormat format, UInt32 Lngth, UInt32 MLngth)
    {
        public string Key = key;
        public byte[] Data = data;
        public SFOFormat Format = format;

        public UInt32 Length = Lngth;
        public UInt32 MaxLength = MLngth;

        public static Type TypeFromFormat(SFOFormat format)
        {
            if (format == SFOFormat.utf8 || format == SFOFormat.utf8S)
            {
                return typeof(string);
            }
            else if (format == SFOFormat.int32)
            {
                return typeof(int);
            }
            else
            {
                throw new InvalidCastException("Unsupported data type or format.");
            }
        }

        public object ReadData()
        {
            if (Format == SFOFormat.utf8)
            {
                object result = System.Text.Encoding.UTF8.GetString(Data);
                return result;
            }
            else if (Format == SFOFormat.utf8S)
            {
                // TODO : Handle utf8S format
                object result = System.Text.Encoding.UTF8.GetString(Data);
                return result;
            }
            else if (Format == SFOFormat.int32)
            {
                object result = BitConverter.ToInt32(Data);
                return result;
            }
            else
            {
                throw new InvalidCastException("Unsupported data type or format.");
            }
        }
    }
}
