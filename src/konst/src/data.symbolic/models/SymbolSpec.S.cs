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

    public readonly struct SymbolSpec<S> : ISymbolSpec<SymbolSpec<S>,S>
        where S : unmanaged
    {
        public readonly S[] Symbols;

        public ushort SymWidth {get;}

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public ushort SegWidth {get;}

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort SegCapacity {get;}

        public ClrArtifactKey SegDomain {get;}

        public ClrArtifactKey SymDomain {get;}

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ClrArtifactKey segdomain,  ClrArtifactKey symdomain, params S[] symbols)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = segdomain;
            SymDomain = symdomain;
            Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ClrArtifactKey symdomain, params S[] symbols)
        {
            SymWidth = symwidth;
            SegWidth = (ushort)bitwidth<S>();
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = typeof(S);
            SymDomain = symdomain;
            Symbols = symbols;
        }

        public bool NonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }

        S[] ISymbolSpec<S>.Symbols
            => Symbols;
    }
}