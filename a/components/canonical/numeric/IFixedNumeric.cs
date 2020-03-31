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
            get => (int)bitsize<T>();
        }    
    }

    /// <summary>
    /// Characterizes a fixed-width data structure that can be interpreted as a numeric data type
    /// </summary>
    /// <typeparam name="F">The reifying structure</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IFixedNumeric<F,T> : IFixedNumeric<T>, IEquatable<F>
        where F : unmanaged, IFixedNumeric<F,T>
        where T : unmanaged
    {

    }       
}