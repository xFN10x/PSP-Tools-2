namespace PSP_Tools_2.SfoClasses
{
    internal class SfoDataFormat
    {
        public SFOFormat Format;
        public enum SFOFormat
        {
            utf8,
            utf8S,
            int32,
            error
        }
        public SfoDataFormat(byte[] fmtBytes)
        {
            ArgumentNullException.ThrowIfNull(fmtBytes);

            var byteString = BitConverter.ToString(fmtBytes);

            if (byteString == "04-00")
            {
                Format = SFOFormat.utf8S;
            }
            else if (byteString == "04-02")
            {
                Format = SFOFormat.utf8;
            }
            else if (byteString == "04-04")
            {
                Format = SFOFormat.int32;
            }
            else
            {
                Format = SFOFormat.error;
            }

        }
    }
}
