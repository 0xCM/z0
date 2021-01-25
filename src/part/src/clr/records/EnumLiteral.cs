//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct EnumLiteral : IComparableRecord<EnumLiteral>
    {
        public const string TableId = "enums.literals";

        public Name Component;

        public Name Type;

        public ClrEnumCode DataType;

        public ushort LiteraIndex;

        public Name LiteralName;

        public ulong ScalarValue;

        public MemoryAddress NameAddress;

        public MemoryAddress TypeAddress;

        static string Identifier(in EnumLiteral src)
            => text.format(RP.SlotDot3, src.Component, src.Type, src.LiteraIndex);

        public int CompareTo(EnumLiteral src)
            => Identifier(this).CompareTo(Identifier(src));
    }
}