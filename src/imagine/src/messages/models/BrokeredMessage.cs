//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct BrokeredMessage<E>
        where E : IAppEvent        
    {
        public readonly bool Accepted;

        public readonly AppMsg Message;

        public static implicit operator BrokeredMessage<E>(bool accepted)
            => new BrokeredMessage<E>(accepted);
        
        public static implicit operator BrokeredMessage<E>((bool accepted, AppMsg msg) src)
            => new BrokeredMessage<E>(src.accepted, src.msg);

        public static bool operator true(BrokeredMessage<E> src)
            => src.Accepted == true;

        public static bool operator false(BrokeredMessage<E> src)
            => src.Accepted == false;

        public static implicit operator bool(BrokeredMessage<E> src)
            => src.Accepted;

        BrokeredMessage(bool accepted)
        {
            this.Accepted = accepted;
            this.Message = DefaultMsg(accepted);
        }

        BrokeredMessage(bool accepted, AppMsg msg)
        {
            Accepted = accepted;            
            Message = msg.IsEmpty ? DefaultMsg(accepted) : msg;
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
            var content = text.concat($"Broker {typeof(E).DisplayName()} receiver acceptions", Chars.Colon, Chars.Space, accepted);
            return accepted ? AppMsg.Info(content) : AppMsg.Warn(content);
        }
    }
}