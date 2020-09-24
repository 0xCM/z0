//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Sink interface root
    /// </summary>
    [Free]
    public interface ISink
    {

    }

    /// <summary>
    /// Characterizes a sink that accepts a single input value
    /// </summary>
    /// <typeparam name="A">The input type</typeparam>
    [Free]
    public interface ISink<A> : ISink
    {
        /// <summary>
        /// Receives supplied input
        /// </summary>
        /// <param name="src">The input</param>
        void Deposit(A src);
    }

    [Free]
    public interface IDataSink<A> : ISink
        where A : struct
    {
        void Deposit(in A src);
    }
}