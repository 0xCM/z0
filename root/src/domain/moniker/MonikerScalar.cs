//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct MonikerScalar
    {
        public static MonikerScalar Define(FixedWidth width, NumericIndicator indicator)
            => new MonikerScalar(width, indicator);

        MonikerScalar(FixedWidth width, NumericIndicator indicator)
        {
            this.Width = width;
            this.Indicator = indicator;
        }

        public readonly FixedWidth Width;
     
        public readonly NumericIndicator Indicator;

        public string Format()
            => $"{Width.Format()}{Indicator.Format()}";

        public NumericKind NumericKind
            => Width.ToNumericKind(Indicator);
    }
}