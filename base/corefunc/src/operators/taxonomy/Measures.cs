//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Characterizes a unary function that returns a scalar value
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="K">The scalar type</typeparam>
    public interface IUnaryMeasure<A,K> : IFunc<A,K>
        where K : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a binary function that returns a scalar value
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="K">The scalar type</typeparam>
    public interface IBinaryMeasure<A,B,K> : IFunc<A,B,K>
        where K : unmanaged
    {

    }
}