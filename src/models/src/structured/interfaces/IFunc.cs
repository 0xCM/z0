//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a function reified as a (structural) type, referred to as a (S)tructural (Func)tion
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc
    {
        string Name 
            => GetType().Tag<OpKindAttribute>().MapValueOrDefault(a => GetType().Name, GetType().Name);
        
        /// <summary>
        /// The operation identity
        /// </summary>
        OpIdentity Id 
            => OpIdentity.Set(Name);        
    }

    /// <summary>
    /// Characterizes a structural emitter; that is, the contract charactrizes a type that implements an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>    
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A> : IFunc
    {
        A Invoke();

        Func<A> Operation 
            => Invoke;
    }

    /// <summary>
    /// Characterizes an identified structural unary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B> : IFunc
    {
        B Invoke(A a);

        Func<A,B> Operation 
            => Invoke;
    }

    /// <summary>
    /// Characterizes an identified structural binary function
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

        Func<A,B,C> Operation 
            => Invoke;
    }

    /// <summary>
    /// Characterizes an identified structural ternary function
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

        Func<A,B,C,D> Operation 
            => Invoke;
    }
}