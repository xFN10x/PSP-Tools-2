namespace PSP_Tools_2.SfoClasses
{
    internal class SfoIndexEntry(UInt16 keyOffset, byte[] fmtBytes, UInt32 dataLength, UInt32 dataMaxLength, UInt32 dataOffset)
    {
        public UInt16 KeyOffset = keyOffset;

        public SfoDataFormat Format = new(fmtBytes);
        public UInt32 DataLength = dataLength;
        public UInt32 DataMaxLength = dataMaxLength;
        public UInt32 DataOffset = dataOffset;

        public string GetDebugString()
        {
            return $"keyoffset: {KeyOffset}, format: {Format.Format}, Length: {DataLength}, Max Length: {DataMaxLength}, Data Offset: {DataOffset}";
        }
    }
}
