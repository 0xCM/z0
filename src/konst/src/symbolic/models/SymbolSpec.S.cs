//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct SymbolSpec<S> : ISymbolSpec<S>
        where S : unmanaged
    {
        public ushort SymWidth {get;}

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public ushort SegWidth {get;}

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort Capacity {get;}

        public ApiArtifactKey SegDomain {get;}

        public ApiArtifactKey SymDomain {get;}

        public S[] Symbols {get;}

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, ApiArtifactKey segdomain,  ApiArtifactKey symdomain, params S[] symbols)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            Capacity = (ushort)(SegWidth/SymWidth);
            SegDomain = segdomain;
            SymDomain = symdomain;
            Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ApiArtifactKey symdomain, params S[] symbols)
        {
            SymWidth = symwidth;
            SegWidth = (ushort)bitwidth<S>();
            Capacity = (ushort)(SegWidth/SymWidth);
            SegDomain = typeof(S);
            SymDomain = symdomain;
            Symbols = symbols;
        }


        public bool NonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }
    }
}