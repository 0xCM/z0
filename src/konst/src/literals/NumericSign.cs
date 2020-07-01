//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NumericSign
    {    
        public readonly NumericSignKind Kind;
        
        [MethodImpl(Inline)]
        public static implicit operator NumericSign(NumericSignKind src)
            => new NumericSign(src);

        [MethodImpl(Inline)]
        public static implicit operator NumericSignKind(NumericSign src)
            => src.Kind;

        [MethodImpl(Inline)]
        public NumericSign(NumericSignKind kind)
        {
            Kind = kind;
        }            
    }
}