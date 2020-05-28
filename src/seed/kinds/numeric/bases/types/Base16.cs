//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Base16 : INumericBase<Base16>
    {
        public static Base16 Base => default;

        [MethodImpl(Inline)]
        public static implicit operator int(Base16 src)
            => (int)src.Modulus;

        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base16 src)
            => src.Modulus;

        public NumericBaseKind Modulus 
            => NumericBaseKind.Base16;        
        
        public NumericBaseIndicator Indicator 
            => NumericBaseIndicator.Base16;
    }    
}