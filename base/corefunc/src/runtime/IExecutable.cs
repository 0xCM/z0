//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Characterizes a thread of execution control that has whatever context it needs, if any, to do something of use
    /// </summary>
    public interface IExecutable
    {
        /// <summary>
        /// Executes the supported operation
        /// </summary>
        void Execute();               
    }

    /// <summary>
    /// Characterizes a thread of execution control that has whatever context it needs, if any, to do something of use
    /// and returns evidence of accomplishment
    /// </summary>
    public interface IExecutable<R> : IExecutable
    {
        new IEnumerable<R> Execute();

        void IExecutable.Execute()
            => Execute();
    }
}