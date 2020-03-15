//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a unary function that returns a scalar value
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="K">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryMeasure<A,K> : IFunc<A,K>
        where K : unmanaged
    {
        
    }
}