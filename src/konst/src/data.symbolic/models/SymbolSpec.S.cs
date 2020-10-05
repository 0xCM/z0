//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct SymbolSpec<S> : ISymbolSpec<S>
        where S : unmanaged
    {
        public ushort SymbolWidth {get;}

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public ushort SegmentWidth {get;}

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort SegmentCapacity {get;}

        public ClrArtifactKey SegmentDomain {get;}

        public ClrArtifactKey SymbolDomain {get;}

        public S[] Symbols {get;}

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ClrArtifactKey segdomain,  ClrArtifactKey symdomain, params S[] symbols)
        {
            SymbolWidth = symwidth;
            SegmentWidth = segwidth;
            SegmentCapacity = (ushort)(SegmentWidth/SymbolWidth);
            SegmentDomain = segdomain;
            SymbolDomain = symdomain;
            Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ClrArtifactKey symdomain, params S[] symbols)
        {
            SymbolWidth = symwidth;
            SegmentWidth = (ushort)bitwidth<S>();
            SegmentCapacity = (ushort)(SegmentWidth/SymbolWidth);
            SegmentDomain = typeof(S);
            SymbolDomain = symdomain;
            Symbols = symbols;
        }


        public bool NonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }
    }
}