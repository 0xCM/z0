//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Root;

    public interface IAppMsgSink : ISink<AppMsg>
    {
        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Notify(AppMsg msg);        

        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Notify(string msg, AppMsgKind? severity = null);

        /// <summary>
        /// Posts an arbitrary number of messages to the queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Notify(IEnumerable<AppMsg> msg)
            => iter(msg,Notify);        

        /// <summary>
        /// Posts a message to the context queue
        /// </summary>
        /// <param name="msg">The message to post</param>
        void NotifyConsole(AppMsg msg)
        {
            term.print(msg);
            Notify(msg.Printed());
        }        

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => NotifyConsole(AppMsg.Colorize(content, color));


        void ISink<AppMsg>.Accept(in AppMsg src)
            => Notify(src);        
    }

    public interface IAppMsgQueue : IAppMsgSink
    {

        IReadOnlyList<AppMsg> Flush();        

        IReadOnlyList<AppMsg> Flush(Exception e);

        void Flush(FilePath dst);
    }

    /// <summary>
    /// Characterizes a stateful thing that functions as an exchange for application messages
    /// </summary>
    public interface IAppMsgExchange : IAppMsgQueue
    {        
        void Flush(Exception exception, IAppMsgLog target);                       
    }

    /// <summary>
    /// A context that supports application message capture/disbursement
    /// </summary>
    public interface IAppMsgContext : IAppMsgExchange, IContext
    {
    
    }    

    public interface IAppMsgLog : IAppMsgSink
    {
        void Write(IEnumerable<AppMsg> src);
        
        void Write(AppMsg src);
        
        void ISink<AppMsg>.Accept(in AppMsg src)
            => Write(src);
    }    
}