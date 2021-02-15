//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a set of S-symbol values, each of bit-width N and covered by a T-storage cell
    /// </summary>
    public readonly struct SymbolSet<S,T,W> : ISymbolSet<S>
        where S : unmanaged
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        public S[] Symbols {get;}

        [MethodImpl(Inline)]
        public SymbolSet(params S[] symbols)
            => Symbols = symbols;

        /// <summary>
        /// The number of bits occupied by a symbol
        /// </summary>
        public ushort SymWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)Widths.data<W>();
        }

        /// <summary>
        /// The width of the underlying numeric primitive
        /// </summary>
        public ushort SegWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)width<T>();
        }

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort SegCapacity
        {
            [MethodImpl(Inline)]
            get => (ushort)((ushort)width<T>()/(ushort)Widths.data<W>());
        }

        public PrimalCode SegDomain
        {
            [MethodImpl(Inline)]
            get => (PrimalCode)Type.GetTypeCode(typeof(T));
        }

        public PrimalCode SymDomain
        {
            [MethodImpl(Inline)]
            get => (PrimalCode)Type.GetTypeCode(typeof(S));
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }

        public SymbolInfo Description
        {
            [MethodImpl(Inline)]
            get => new SymbolInfo(SymWidth, SegWidth, SegDomain, SymDomain);
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolInfo(SymbolSet<S,T,W> src)
            => src.Description;

        [MethodImpl(Inline)]
        public static implicit operator SymbolSet<S>(SymbolSet<S,T,W> src)
            => new SymbolSet<S>(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain, src.Symbols);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSet<S,W>(SymbolSet<S,T,W> src)
            => new SymbolSet<S,W>(src.SegWidth, src.SegDomain, src.Symbols);
    }
}