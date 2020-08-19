//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SegSpec : ITextual
    {        
        public readonly SegIndicator Indicator;

        public readonly DataWidth Width;

        public readonly PrimalNumericKind CellType;
        
        [MethodImpl(Inline)]
        public SegSpec(SegIndicator i, DataWidth w, PrimalNumericKind nk)
        {
            Indicator = i;
            Width = w;
            CellType = nk;
        }

        public string Format()
            => text.format("{0}x{1}x{2}", Width, CellType, Indicator);
    }
}