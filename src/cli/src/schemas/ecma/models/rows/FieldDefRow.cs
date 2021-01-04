namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;


    [StructLayout(LayoutKind.Sequential)]
    public struct FieldDefRow : IRecord<FieldDefRow>
    {
        public RowKey Key;

        public FieldAttributes Flags;

        public FK<name> Name;

        public FK<sig> Signature;
    }
}