//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SymbolSpec : ISymbolSpec
    {
        public ushort SymWidth {get;}

        public ushort SegWidth {get;}

        public ushort Capacity {get;}

        public ApiArtifactKey SegDomain {get;}

        public ApiArtifactKey SymDomain {get;}

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ApiArtifactKey seg, ApiArtifactKey sym)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            Capacity = (ushort)(SegWidth/SymWidth);
            SegDomain = seg;
            SymDomain = sym;
        }
    }
}