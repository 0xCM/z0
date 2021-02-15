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

    public readonly struct SymbolSet<S> : ISymbolSet<SymbolSet<S>,S>
        where S : unmanaged
    {
        public S[] Symbols {get;}

        public ushort SymWidth {get;}

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public ushort SegWidth {get;}

        /// <summary>
        /// The maximum number of symbols that can be stored in a segment
        /// </summary>
        public ushort SegCapacity {get;}

        public PrimalCode SegDomain {get;}

        public PrimalCode SymDomain {get;}

        [MethodImpl(Inline)]
        public SymbolSet(ushort symwidth, ushort segwidth, PrimalCode segdomain, PrimalCode symdomain, params S[] symbols)
        {
            SymWidth = symwidth;
            SegWidth = segwidth;
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = segdomain;
            SymDomain = symdomain;
            Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public SymbolSet(ushort symwidth, PrimalCode symdomain, params S[] symbols)
        {
            SymWidth = symwidth;
            SegWidth = (ushort)width<S>();
            SegCapacity = (ushort)(SegWidth/SymWidth);
            SegDomain = (PrimalCode)Type.GetTypeCode(typeof(S));
            SymDomain = symdomain;
            Symbols = symbols;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbols != null  && Symbols.Length != 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => !IsNonEmpty;
        }

        public SymbolInfo Description
        {
            [MethodImpl(Inline)]
            get => new SymbolInfo(SymWidth, SegWidth, SegDomain, SymDomain);
        }
    }
}