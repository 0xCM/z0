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

    [SuppressUnmanagedCodeSecurity]
    public interface IAction<A> : IFunc
    {
        void Invoke(A a);
    }

    /// <summary>
    /// Characterizes an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>    
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A> : IFunc
    {
        A Invoke();

        FunctionClass IFunc.Class => FunctionClass.Func0;        
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

        FunctionClass IFunc.Class => FunctionClass.UnaryFunc;
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

        FunctionClass IFunc.Class => FunctionClass.BinaryFunc;
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

        FunctionClass IFunc.Class => FunctionClass.TernaryFunc;
    }
}