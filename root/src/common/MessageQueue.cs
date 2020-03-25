//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;

    using static Root;

    public interface IMessageSource<M> : ICallbackSouce<M>
        where M : ICustomFormattable
    
    {

    }

    public interface IMessageSink<M> : ISink<M>
        where  M : IAppMsg
    {
        void Notify(M msg);        
        
        void Notify(IEnumerable<M> msg)
            => iter(msg,Notify);        

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

    public interface IMessageQueue<M> : IMessageSink<M>, ICallbackSouce<M>
        where M : IAppMsg
    {
        IReadOnlyList<M> Dequeue();       

        void Emit(FilePath dst);         
    }

    public interface IMessageLog<M> : IMessageSink<M>
        where M : IAppMsg
    {
        void Write(IEnumerable<M> src);
        
        void Write(M src);

        void ISink<M>.Accept(in M src)
            => Write(src);
    }        
}