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

    public interface IContext
    {
        /// <summary>
        /// Removes the messages accumulated by the context and returns these messages to the caller
        /// </summary>
        IReadOnlyList<AppMsg> DequeuePosts();

        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostMessage(AppMsg msg);

        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostMessage(string msg, SeverityLevel? severity = null);

        /// <summary>
        /// Posts an exception, from wich a message is derived, to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void PostError(Exception e);        

        /// <summary>
        /// Specifies context RNG
        /// </summary>
        IPolyrand Random {get;}
    }
}