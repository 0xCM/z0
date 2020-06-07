//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    public readonly struct SymbolSpec<S> : ISymbolSpec<S>
        where S : unmanaged
    {
        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, ushort segwidth, MetadataToken segdomain,  MetadataToken symdomain, params S[] symbols)
        {
            this.SymWidth = symwidth;
            this.SegWidth = segwidth;
            this.Capacity = (ushort)(SegWidth/SymWidth);
            this.SegDomain = segdomain;
            this.SymDomain = symdomain;
            this.Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public SymbolSpec(ushort symwidth, MetadataToken symdomain, params S[] symbols)
        {
            this.SymWidth = symwidth;
            this.SegWidth = (ushort)Control.bitsize<S>();
            this.Capacity = (ushort)(SegWidth/SymWidth);
            this.SegDomain = typeof(S);
            this.SymDomain = symdomain;
            this.Symbols = symbols;
        }

        public ushort SymWidth {get;}
        
        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public ushort SegWidth {get;}

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort Capacity {get;}

        public MetadataToken SegDomain {get;}

        public MetadataToken SymDomain {get;}

        public S[] Symbols {get;}

        public bool DefinesSymbols
        {
            [MethodImpl(Inline)]
            get => Symbols == null || Symbols.Length == 0;
        }
    }


}