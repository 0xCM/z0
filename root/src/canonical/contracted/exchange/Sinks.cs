//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
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
}