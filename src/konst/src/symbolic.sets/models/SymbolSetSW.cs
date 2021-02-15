//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies symbol characteristics
    /// </summary>
    public readonly struct SymbolSet<S,W> : ISymbolSet<S>
        where S : unmanaged
        where W : unmanaged, IDataWidth
    {
        /// <summary>
        /// The specified symbols
        /// </summary>
        public S[] Symbols {get;}

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public ushort SegWidth {get;}

        /// <summary>
        /// The storage cell type identifier
        /// </summary>
        public PrimalCode SegDomain {get;}

        [MethodImpl(Inline)]
        public SymbolSet(ushort wSeg, PrimalCode dSeg, params S[] symbols)
        {
            SegDomain = dSeg;
            SegWidth = wSeg;
            Symbols = symbols;
        }

        /// <summary>
        /// The number of bits occupied by a symbol
        /// </summary>
        public ushort SymWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)Widths.data<W>();
        }

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort SegCapacity
        {
            [MethodImpl(Inline)]
            get => (ushort)(SegWidth/SymWidth);
        }

        public PrimalCode SymDomain
        {
            [MethodImpl(Inline)]
            get => (PrimalCode)Type.GetTypeCode(typeof(S));
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols == null  || Symbols.Length == 0;
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
        public static implicit operator SymbolInfo(SymbolSet<S,W> src)
            => src.Description;

        [MethodImpl(Inline)]
        public static implicit operator SymbolSet<S>(SymbolSet<S,W> src)
            => new SymbolSet<S>(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain);
    }
}