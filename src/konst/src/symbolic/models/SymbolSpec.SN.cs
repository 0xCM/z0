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
    /// Specifes symbol characteristics
    /// </summary>
    public readonly struct SymbolSpec<S,W> : ISymbolSpec<S>
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
        public ArtifactIdentifier SegDomain {get;}

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
        public ushort Capacity
        {
            [MethodImpl(Inline)]
            get => (ushort)(SegWidth/SymWidth);
        }

        public ArtifactIdentifier SymDomain
        {
            [MethodImpl(Inline)]
            get => typeof(S);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }

        [MethodImpl(Inline)]
        public SymbolSpec(ushort segwidth, ArtifactIdentifier segdomain, params S[] symbols)
        {
            SegDomain = segdomain;
            SegWidth = segwidth;
            Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec(SymbolSpec<S,W> src)
            => new SymbolSpec(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSpec<S>(SymbolSpec<S,W> src)
            => new SymbolSpec<S>(src.SymWidth, src.SegWidth, src.SegDomain, src.SymDomain);
    }
}