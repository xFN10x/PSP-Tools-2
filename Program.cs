using System.Diagnostics;
using Ini.Net;

namespace PSP_Tools_2
{
    internal static class Program
    {
        public static Boolean PSPSelected = false;
        public static String PSPFolder;
        public static String ISOFolder;

        public static Form MainForm = new MainForm();
        public static String SaveFileLocation = AppDomain.CurrentDomain.BaseDirectory;
        public static void ShowModal(Form form)
        {
            form.ShowDialog(MainForm);
        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public static SFOReader ReadSFO(String file)
        {

            return new SFOReader(file);

        }

        public static void SetPSP(Form form, String pspfolder, String isoFolder)
        {
            Debug.WriteLine(pspfolder);
            Debug.WriteLine(isoFolder);
            if (Directory.Exists(pspfolder) && Directory.Exists(isoFolder))
            {
                PSPFolder = pspfolder;
                ISOFolder = isoFolder;
                PSPSelected = true;
                MessageBox.Show(form, "PSP Selected.", "Selection Success", MessageBoxButtons.OK);
                form.Close();
                var iniFile = new IniFile("settings.ini");

                iniFile.WriteString("LastPSPSelected", "PSP", PSPFolder);
                iniFile.WriteString("LastPSPSelected", "ISO", ISOFolder);
            }
            else
            {
                MessageBox.Show(form, "Not a PSP!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (!File.Exists(SaveFileLocation + "settings.ini"))
            {
                Program.ShowModal(new PSPSelectionForm());
            }
            else
            {
                var iniFile = new IniFile("settings.ini");
                PSPFolder = iniFile.ReadString("LastPSPSelected", "PSP");
                ISOFolder = iniFile.ReadString("LastPSPSelected", "ISO");
                if (Directory.Exists(PSPFolder) && Directory.Exists(ISOFolder))
                {
                    PSPSelected = true;
                }
                else
                {
                    Debug.WriteLine(PSPFolder);
                    Debug.WriteLine(ISOFolder);
                    if (MessageBox.Show(MainForm, "PSP not connected/moved drives. Reselect?", "PSP Moved", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) Program.ShowModal(new PSPSelectionForm());
                }
            }
            if (!Directory.Exists(SaveFileLocation + @"backups\")) Directory.CreateDirectory(SaveFileLocation + @"backups\");


            Application.Run(MainForm);
        }
    }
}