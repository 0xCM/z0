//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct EnumLiteralRow : IComparableRecord<EnumLiteralRow>
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

        static string Identifier(in EnumLiteralRow src)
            => text.format(RP.SlotDot3, src.Component, src.Type, src.LiteraIndex);

        public int CompareTo(EnumLiteralRow src)
            => Identifier(this).CompareTo(Identifier(src));
    }
}