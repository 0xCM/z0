//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Identifies a function that returns a scalar value
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IMeasure : IFunc
    {

    }

    /// <summary>
    /// Characterizes a unary function that returns a scalar value
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="K">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryMeasure<A,K> : IMeasure, IFunc<A,K>
        where K : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.UnaryMeasure;        
    }

    /// <summary>
    /// Characterizes a homogenous binary function that returns a scalar value
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="K">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryMeasure<A,K> : IMeasure, IFunc<A,A,K>
        where K : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.BinaryMeasure;
    }

    /// <summary>
    /// Characterizes a homogenous ternary function that returns a scalar value
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="K">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryMeasure<A,K> : IMeasure, IFunc<A,A,A,K>
        where K : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryMeasure;
    }
}