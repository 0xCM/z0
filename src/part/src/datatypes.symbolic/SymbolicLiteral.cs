//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct SymbolicLiteral : IComparableRecord<SymbolicLiteral>
    {
        public const string TableId = "symbolic.literals";

        public Name Component;

        public Name Type;

        public ClrPrimalKind DataType;

        public ushort LiteraIndex;

        public Name LiteralName;

        public ulong ScalarValue;

        public MemoryAddress NameAddress;

        public MemoryAddress TypeAddress;

        static string Identifier(in SymbolicLiteral src)
            => text.format(RP.SlotDot3, src.Component, src.Type, src.LiteraIndex);

        public int CompareTo(SymbolicLiteral src)
            => Identifier(this).CompareTo(Identifier(src));
    }
}