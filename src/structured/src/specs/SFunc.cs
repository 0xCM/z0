//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISAction<A> : ISFunc
    {
        void Invoke(A a);

        Action<A> Operation => Invoke;
    }    

    /// <summary>
    /// Characterizes a structural emitter; that is, the contract charactrizes a type that implements an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>    
    [SuppressUnmanagedCodeSecurity]
    public interface ISFunc<A> : ISFunc
    {
        A Invoke();

        Func<A> Operation => Invoke;
    }

    /// <summary>
    /// Characterizes a structural binary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFunc<A,B,C> : ISFunc
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

}