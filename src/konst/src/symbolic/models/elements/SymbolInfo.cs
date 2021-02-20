//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct SymbolInfo : ISymbolInfo
    {
        public ushort SymWidth {get;}

        public ushort SegWidth {get;}

        public ushort SegCapacity {get;}

        public PrimalCode SegDomain {get;}

        public PrimalCode SymDomain {get;}

        public PrimalCode KindDomain {get;}

        [MethodImpl(Inline)]
        public SymbolInfo(ushort symwidth, ushort segwidth, PrimalCode seg, PrimalCode sym, PrimalCode kind = default)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = seg;
            SymDomain = sym;
            KindDomain = kind;
        }
    }
}