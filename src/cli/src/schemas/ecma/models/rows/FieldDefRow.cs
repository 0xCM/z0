namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    using static Relations;

    [StructLayout(LayoutKind.Sequential)]
    public struct FieldDefRow : IRecord<FieldDefRow>
    {
        public RowKey Key;

        public FieldAttributes Flags;

        public FK<StringIndex> Name;

        public FK<BlobIndex> Signature;
    }
}