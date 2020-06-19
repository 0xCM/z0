//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDecrementableOps<T> 
        where T : unmanaged
    {
        T Dec(T x);        
    }

    public interface IIncrementableOps<T>
        where T : unmanaged
    {
        T Inc(T x);        
    }

    /// <summary>
    /// Characterizes a type that realizes both incrementing and decrementing operations
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    public interface IStepwiseOps<T> : IIncrementableOps<T>, IDecrementableOps<T>
        where T : unmanaged
    {
        
    }


}