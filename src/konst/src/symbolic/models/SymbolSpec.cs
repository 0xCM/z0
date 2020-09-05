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

        public ArtifactIdentifier SegDomain {get;}

        public ArtifactIdentifier SymDomain {get;}

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ArtifactIdentifier seg, ArtifactIdentifier sym)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            Capacity = (ushort)(SegWidth/SymWidth);
            SegDomain = seg;
            SymDomain = sym;
        }
    }
}