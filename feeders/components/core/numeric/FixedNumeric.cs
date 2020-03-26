//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface IFixedNumeric<T> : IFixed<T>
        where T : unmanaged        
    {
        T Data {get;set;}

        NumericKind NumericKind
        {
            [MethodImpl(Inline)]
            get => typeof(T).NumericKind();
        }

        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => (int)core.bitsize<T>();
        }    
    }

    public interface IFixedNumeric<F,T> : IFixedNumeric<T>, IEquatable<F>
        where F : unmanaged, IFixedNumeric<F,T>
        where T : unmanaged
    {

    }       
}