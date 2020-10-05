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
        public ushort SymbolWidth {get;}

        public ushort SegmentWidth {get;}

        public ushort SegmentCapacity {get;}

        public ClrArtifactKey SegmentDomain {get;}

        public ClrArtifactKey SymbolDomain {get;}

        public ClrArtifactKey KindDomain {get;}

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ClrArtifactKey seg, ClrArtifactKey sym, ClrArtifactKey kind = default)
        {
            SymbolWidth = symwidth;
            SegmentWidth = segwidth;
            SegmentCapacity = (ushort)(SegmentWidth/SymbolWidth);
            SegmentDomain = seg;
            SymbolDomain = sym;
            KindDomain = kind;
        }
    }
}