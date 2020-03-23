//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IStructural
    {
        
    }

    /// <summary>
    /// Characterizes a function reified as a (structural) type. 
    /// </summary>
    /// <remarks>
    /// This provides motivation for calling these things structural fuunctions, I suppose
    /// </remarks>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc : IStructural
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
    /// Characterizes a structural function that is width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWFunc<W> : IFunc
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural emitter; that is, the contract charactrizes a type
    /// that implements an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>    
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A> : IFunc
    {
        A Invoke();

        Func<A> Operation => Invoke;

    }

    /// <summary>
    /// Characterizes a structural emitter with emission type of known width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWFunc<W,A> : IFunc<A>, IWFunc<W>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural unary function
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
    /// Characterizes a structural unary function with operand and result type of known and common width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWFunc<W,A,B> : IFunc<A,B>, IWFunc<W>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural binary function
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
    /// Characterizes a structural binary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWFunc<W,A,B,C> : IFunc<A,B,C>, IWFunc<W>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural ternary function
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
    /// Characterizes a structural ternary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IWFunc<W,A,B,C,D> : IFunc<A,B,C,D>, IWFunc<W>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural emission function
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface INullaryFunc<A> : IFunc<A>
    {

    }

    /// <summary>
    /// Characterizes a structural emitter with result type of known width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface INullaryFunc<W,A> : INullaryFunc<A>, IWFunc<W,A>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural unary function
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryFunc<A,B> : IFunc<A,B>
    {

    }

    /// <summary>
    /// Characterizes a structural unary function with operand and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryFunc<W,A,B> : IUnaryFunc<A,B>, IWFunc<W,A,B>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural binary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryFunc<A,B,C> : IFunc<A,B,C>
    {
        
    }

    /// <summary>
    /// Characterizes a structural binary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryFunc<W,A,B,C> : IBinaryFunc<A,B,C>, IWFunc<W,A,B,C>
        where W : struct, ITypeWidth<W>
    {

    }

    /// <summary>
    /// Characterizes a structural ternary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryFunc<A,B,C,D> : IFunc<A,B,C,D>
    {
        
    }

    /// <summary>
    /// Characterizes a structural ternary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryFunc<W,A,B,C,D> : ITernaryFunc<A,B,C,D>, IWFunc<W,A,B,C,D>
        where W : struct, ITypeWidth<W>
    {

    }
}