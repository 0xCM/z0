//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes an application message receptacle
    /// </summary>
    /// <typeparam name="M">The message type</typeparam>
    public interface IMessageSink<M> : ISink<M>
        where  M : IAppMsg
    {
        void Notify(M msg);        
        
        void Notify(IEnumerable<M> msg)
            => Control.iter(msg,Notify);        

        void NotifyConsole(M msg, AppMsgColor color)
        {
            term.print(msg, color);
            Displayed(msg);
        }

        void NotifyConsole(M msg)
            => NotifyConsole(msg, msg.Color);

        void Displayed(M msg) {}

        void ISink<M>.Accept(in M src)
            => Notify(src);        
    }
}