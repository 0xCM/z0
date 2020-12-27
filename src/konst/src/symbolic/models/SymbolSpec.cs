//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record(TableId)]
    public struct SymbolSpec : ISymbolSpec, IRecord<SymbolSpec>
    {
        public const string TableId = "symbols.spec";

        public ushort SymWidth;

        public ushort SegWidth;

        public ushort SegCapacity;

        public ClrToken SegDomain;

        public ClrToken SymDomain;

        public ClrToken KindDomain;

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ClrToken seg, ClrToken sym, ClrToken kind = default)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = seg;
            SymDomain = sym;
            KindDomain = kind;
        }

        ushort ISymbolSpec.SymWidth
            => SymWidth;

        ushort ISymbolSpec.SegWidth
            => SegWidth;

        ushort ISymbolSpec.SegCapacity
            => SegCapacity;

        ClrToken ISymbolSpec.SegDomain
            => SegDomain;

        ClrToken ISymbolSpec.SymDomain
            => SymDomain;
    }
}