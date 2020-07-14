//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct MessageInfo
    {
        public MessageInfo(int i)        
        {
            MessageType = EmptyString;
            MessageId = default;
            MessageBody = EmptyString;
        }

        public MessageInfo(Guid MessageId, string MessageType, string MessageBody)
        {
            this.MessageId = MessageId;
            this.MessageType = MessageType;
            this.MessageBody = MessageBody;
        }

        public string MessageType { get; set; }

        public Guid MessageId { get; set; }

        public string MessageBody { get; set; }

        public override string ToString()
            => $"{MessageType} : {MessageBody}";
    }
}