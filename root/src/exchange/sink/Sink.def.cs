//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public delegate void SinkReceiver<T>(in T src);

    public delegate void SinkReceiver<A,B>(in A a, in B b);

    public delegate void SinkReceiver<A,B,C>(in A a, in B b, in C c);

    /// <summary>
    /// Sink interface root
    /// </summary>
    public interface ISink
    {

    }

    /// <summary>
    /// Characterizes a sink that accepts a single input value
    /// </summary>
    /// <typeparam name="A">The input type</typeparam>
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