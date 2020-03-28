//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static root;

    public static class AppEventBrokerOps
    {
        [MethodImpl(Inline)]
        public static BrokerAcceptance<E> Receive<E>(this E e, IAppEventBroker broker, Action<E> receiver)
            where E : IAppEvent
                => broker.AcceptReceiver(receiver);        
    }

    public readonly struct BrokerAcceptance<E>
        where E : IAppEvent        
    {
        public readonly bool Accepted;

        public readonly AppMsg Message;

        public static implicit operator BrokerAcceptance<E>(bool accepted)
            => new BrokerAcceptance<E>(accepted);
        
        public static implicit operator BrokerAcceptance<E>((bool accepted, AppMsg msg) src)
            => new BrokerAcceptance<E>(src.accepted, src.msg);

        public static bool operator true(BrokerAcceptance<E> src)
            => src.Accepted == true;

        public static bool operator false(BrokerAcceptance<E> src)
            => src.Accepted == false;

        public static implicit operator bool(BrokerAcceptance<E> src)
            => src.Accepted;

        BrokerAcceptance(bool accepted)
        {
            this.Accepted = accepted;
            this.Message = DefaultMsg(accepted);
        }

        BrokerAcceptance(bool accepted, AppMsg msg)
        {
            this.Accepted = accepted;            
            this.Message = msg.IsEmpty ? DefaultMsg(accepted) : msg;
        }
        
        public void Deconstruct(out bool accepted, out AppMsg msg)
        {
            accepted = Accepted;
            msg = Message;
        }

        public string Format()
            => Message.Format();

        public override string ToString()
            => Format();

        static AppMsg DefaultMsg(bool accepted)
        {
            var content = text.concat($"Broker {typeof(E).DisplayName()} receiver acceptions", text.colon(), text.space(), accepted);
            return accepted ? AppMsg.Info(content) : AppMsg.Warn(content);
        }
    }
}