//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct StatusMsg<T> : IAppMsg
    {
        public const MsgLevel Level = MsgLevel.Status;

        public MsgId MsgId {get;}

        public MsgPayload<T> Payload {get;}

        [MethodImpl(Inline)]
        public StatusMsg(T data)
        {
            MsgId = (Level, root.timestamp());
            Payload = data;
        }

        public MsgFlair Flair
            => MsgFlair.Status;

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(MsgId, Payload);

        public override string ToString()
            => Format();

        LogLevel IAppMsg.Kind
            => (LogLevel)Level;

        FlairKind IAppMsg.Flair
             => (FlairKind)Flair;
    }
}