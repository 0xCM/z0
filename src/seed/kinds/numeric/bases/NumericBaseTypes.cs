//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INumericBase
    {
        NumericBaseKind Modulus {get;}
    }

    public interface INumericBase<F> : INumericBase
        where F : unmanaged, INumericBase<F>
    {
        
    }

    public readonly struct Base2 : INumericBase<Base2>
    {
        [MethodImpl(Inline)]
        public static implicit operator int(Base2 src)
            => (int)src.Modulus;
    
        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base2 src)
            => src.Modulus;

        public NumericBaseKind Modulus 
            => NumericBaseKind.B;        
    }    

    public readonly struct Base8 : INumericBase<Base8>
    {
        [MethodImpl(Inline)]
        public static implicit operator int(Base8 src)
            => (int)src.Modulus;

        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base8 src)
            => src.Modulus;

        public NumericBaseKind Modulus 
            => NumericBaseKind.O;        
    }    

    public readonly struct Base10  : INumericBase<Base10>
    {
        [MethodImpl(Inline)]
        public static implicit operator int(Base10 src)
            => (int)src.Modulus;

        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base10 src)
            => src.Modulus;

        public NumericBaseKind Modulus 
            => NumericBaseKind.D;        
    }    

    public readonly struct Base16 : INumericBase<Base16>
    {
        [MethodImpl(Inline)]
        public static implicit operator int(Base16 src)
            => (int)src.Modulus;

        [MethodImpl(Inline)]
        public static implicit operator NumericBaseKind(Base16 src)
            => src.Modulus;

       public NumericBaseKind Modulus 
            => NumericBaseKind.X;        
    }    
}