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

    /// <summary>
    /// Defines a set of S-symbol values, each of bit-width N and covered by a T-storage cell
    /// </summary>
    public readonly struct SymbolSpec<S,T,W> : ISymbolSpec<S>
        where S : unmanaged
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        public S[] Symbols {get;}

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec(SymbolSpec<S,T,W> src)
            => new SymbolSpec(src.SymbolWidth, src.SegmentWidth, src.SegmentDomain, src.SymbolDomain);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec<S>(SymbolSpec<S,T,W> src)
            => new SymbolSpec<S>(src.SymbolWidth, src.SegmentWidth, src.SegmentDomain, src.SymbolDomain, src.Symbols);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec<S,W>(SymbolSpec<S,T,W> src)
            => new SymbolSpec<S,W>(src.SegmentWidth, src.SegmentDomain, src.Symbols);

        [MethodImpl(Inline)]
        public SymbolSpec(params S[] symbols)
            => Symbols = symbols;

        /// <summary>
        /// The number of bits occupied by a symbol
        /// </summary>
        public ushort SymbolWidth
        {
            [MethodImpl(Inline)]
            get => (ushort) Widths.data<W>();
        }

        /// <summary>
        /// The width of the underlying numeric primitive
        /// </summary>
        public ushort SegmentWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)bitwidth<T>();
        }

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort SegmentCapacity
        {
            [MethodImpl(Inline)]
            get => (ushort)((ushort)bitwidth<T>()/(ushort)Widths.data<W>());
        }

        public ClrArtifactKey SegmentDomain
        {
            [MethodImpl(Inline)]
            get => typeof(T);
        }

        public ClrArtifactKey SymbolDomain
        {
            [MethodImpl(Inline)]
            get => typeof(S);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }
    }
}