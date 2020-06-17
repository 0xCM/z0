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

    /// <summary>
    /// Specifes symbol characteristics
    /// </summary>
    public readonly struct SymbolSpec<S,N> : ISymbolSpec<S>
        where S : unmanaged
        where N : unmanaged, ITypeNat
    {       
        [MethodImpl(Inline)]
        public SymbolSpec(ushort segwidth, MetadataToken segdomain, params S[] symbols)
        {
            this.SegDomain = segdomain;
            this.SegWidth = segwidth;
            this.SymWidth = (ushort)Typed.value<N>();
            this.Symbols = symbols;
            this.Capacity = (ushort)(SegWidth/SymWidth);
        }
        
        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec(SymbolSpec<S,N> src)
            => new SymbolSpec(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain);
        
        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec<S>(SymbolSpec<S,N> src)
            => new SymbolSpec<S>(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain);

        /// <summary>
        /// The number of bits occupied by a symbol
        /// </summary>
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

        public MetadataToken SymDomain
        {
            [MethodImpl(Inline)]
            get => typeof(S);
        }

        public S[] Symbols {get;}

        public bool DefinesSymbols
        {
            [MethodImpl(Inline)]
            get => Symbols == null || Symbols.Length == 0;
        }
    }


}