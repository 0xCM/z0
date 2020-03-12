//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    /// <summary>
    /// Sink interface root
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface ISink
    {

    }

    /// <summary>
    /// Characterizes a sink that accepts a single input value
    /// </summary>
    /// <typeparam name="A">The input type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISink<A> : ISink
    {
        /// <summary>
        /// Receives supplied input
        /// </summary>
        /// <param name="src">The input</param>
        void Accept(in A src);        
    }

    /// <summary>
    /// Characterizes a sink that accepts a pair of input values
    /// </summary>
    /// <typeparam name="A">The first input type</typeparam>
    /// <typeparam name="B">The second input type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISink<A,B> : ISink
    {
        /// <summary>
        /// Receives an input pair
        /// </summary>
        /// <param name="a">The first input</param>
        /// <param name="b">The second input</param>
        void Accept(in A a, in B b);
    }

    /// <summary>
    /// Characterizes a sink that accepts an input triple
    /// </summary>
    /// <typeparam name="A">The first input type</typeparam>
    /// <typeparam name="B">The second input type</typeparam>
    /// <typeparam name="C">The third input type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISink<A,B,C> : ISink
    {
        /// <summary>
        /// Receives an input triple
        /// </summary>
        /// <param name="a">The first input</param>
        /// <param name="b">The second input</param>
        /// <param name="c">The third input</param>
        void Accept(in A a, in B b, in C c);
    }
}