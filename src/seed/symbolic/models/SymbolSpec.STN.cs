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
    public readonly struct SymbolSpec<S,T,N>  : ISymbolSpec<S>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {       
        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec(SymbolSpec<S,T,N> src)
            => new SymbolSpec(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec<S>(SymbolSpec<S,T,N> src)
            => new SymbolSpec<S>(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain, src.Symbols);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec<S,N>(SymbolSpec<S,T,N> src)
            => new SymbolSpec<S,N>(src.SegWidth, src.SegDomain, src.Symbols);

        [MethodImpl(Inline)]
        public SymbolSpec(params S[] symbols)
        {
            Symbols = symbols;
        }    

        /// <summary>
        /// The number of bits occupied by a symbol
        /// </summary>
        public ushort SymWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)Typed.value<N>();
        }

        /// <summary>
        /// The width of the underlying numeric primitive
        /// </summary>
        public ushort SegWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)Root.bitsize<T>();
        }

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort Capacity
        {
            [MethodImpl(Inline)]
            get => (ushort)((ushort)Root.bitsize<T>()/(ushort)Typed.value<N>());
        }

        public MetadataToken SegDomain
        {
            [MethodImpl(Inline)]
            get => typeof(T);
        }

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
