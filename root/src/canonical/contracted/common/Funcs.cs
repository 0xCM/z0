//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    [SuppressUnmanagedCodeSecurity]
    public interface IFunc
    {
        /// <summary>
        /// The operation identity
        /// </summary>
        OpIdentity Id {get;} 

        /// <summary>
        /// Specifies the function kind classification
        /// </summary>
        FunctionClass Class => FunctionClass.None;       
    }

    /// <summary>
    /// Characterizes an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>    
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A> : IFunc
    {
        A Invoke();

        Func<A> Operation => Invoke;

    }

    /// <summary>
    /// Characterizes a unary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B> : IFunc
    {
        B Invoke(A a);

        Func<A,B> Operation => Invoke;

    }

    /// <summary>
    /// Characterizes a binary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B,C> : IFunc
    {
        /// <summary>
        /// Invokes the reified function over supplied operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        C Invoke(A a, B b);

        Func<A,B,C> Operation => Invoke;

    }

    /// <summary>
    /// Characterizes a ternary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B,C,D> : IFunc
    {
        /// <summary>
        /// Invokes the reified function over supplied operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        D Invoke(A a, B b, C c);

        Func<A,B,C,D> Operation => Invoke;

    }

    /// <summary>
    /// Characterizes an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface INullaryFunc<A> : IFunc<A>
    {

    }

    /// <summary>
    /// Characterizes a unary function
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryFunc<A,B> : IFunc<A,B>
    {

    }

    /// <summary>
    /// Characterizes a binary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryFunc<A,B,C> : IFunc<A,B,C>
    {
        
    }

    /// <summary>
    /// Characterizes a ternary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryFunc<A,B,C,D> : IFunc<A,B,C,D>
    {
        
    }
}