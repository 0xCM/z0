namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct FieldDefRow : IRecord<FieldDefRow>
    {
        public RowKey Key;

        public ushort Flags;

        public FK<name> Name;

        public FK<sig> Signature;
    }
}