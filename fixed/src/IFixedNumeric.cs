//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IFixedNumeric<T> : IFixed<T>, IFixedWidth
        where T : unmanaged        
    {
        T Data {get;set;}

        NumericKind NumericKind
        {
            [MethodImpl(Inline)]
            get => typeof(T).NumericKind();
        }

        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)bitsize<T>();
        }

        int IFixed.BitCount
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<T>();
        }    
    }

    public interface IFixedNumeric<F,T> : IFixedNumeric<T>, IEquatable<F>
        where F : unmanaged, IFixedNumeric<F,T>
        where T : unmanaged
    {

    }
}