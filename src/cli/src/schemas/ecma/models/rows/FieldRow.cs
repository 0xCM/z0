namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;


    [StructLayout(LayoutKind.Sequential)]
    public struct FieldRow : IRecord<FieldRow>
    {
        public RowKey Key;

        public FieldAttributes Flags;

        public StringIndex Name;

        public BlobIndex Signature;
    }
}