//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Base3 : INumericBase<Base3>
    {
        [MethodImpl(Inline)]
        public static implicit operator int(Base3 src)
            => (int)src.Modulus;
    
        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base3 src)
            => src.Modulus;

        public NumericBaseKind Modulus 
            => NumericBaseKind.T;        
    }    
}