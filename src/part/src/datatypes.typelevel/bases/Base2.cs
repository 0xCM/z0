//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Base2 : INumericBase<Base2>
    {
        public static Base2 Base => default;

        [MethodImpl(Inline)]
        public static implicit operator int(Base2 src)
            => (int)src.Modulus;

        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base2 src)
            => src.Modulus;

        public NumericBaseKind Modulus
            => NumericBaseKind.Base2;

        public NumericBaseIndicator Indicator
            => NumericBaseIndicator.Base2;
    }
}