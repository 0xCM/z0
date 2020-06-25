//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IFixedNumeric<F,T> : IFixed<F,T>
        where F : struct, IFixedNumeric<F,T>
        where T : struct
    {
        int IFixed.BitWidth 
            => Unsafe.SizeOf<T>()*8; 

        int IFixed.ByteCount 
            => Unsafe.SizeOf<T>(); 

        NumericKind NumericKind 
            => NumericKinds.kind<T>(); 

        NumericWidth NumericWidth 
            => (NumericWidth)(Unsafe.SizeOf<T>()*8); 
    }

    public interface IFixedNumeric<F,W,T> : IFixedNumeric<F,T>
        where F : unmanaged, IFixedNumeric<F,W,T>
        where W : unmanaged, ITypeWidth  
        where T : struct
    {
        
    }    
}