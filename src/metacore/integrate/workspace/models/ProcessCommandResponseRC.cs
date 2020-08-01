//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class ProcessComandResponse<R,C> : IProcessResponseMessage<R,C>
        where R : ProcessComandResponse<R,C>
        where C : IProcessCommand
    {
        public ProcessMessage Content {get;}

        public C Command { get; }

        public static implicit operator ProcessCommandResponseAdapter(ProcessComandResponse<R,C> response)
            => new ProcessCommandResponseAdapter(new ProcessCommandAdapter(response.Command), response);
            
        protected ProcessComandResponse(C command, ProcessMessage content)
        {
            Command = command;
            Content = content ?? ProcessMessage.Empty(command.CommandName);
        }

        protected ProcessComandResponse(C command, IMessage content)
        {
            Command = command;
            Content = content as ProcessMessage ?? ProcessMessage.Empty(command.CommandName);
        }

        Guid IMessage.MessageId
            => Content.MessageId;


        public override string ToString()
            => Content.ToString();

        string IMessage.ToCanonicalForm()
            => Content.ToCanonicalForm();

        IProcessCommand IProcessResponseMessge.Command
            => Command;

        IProcessResponseMessge IProcessResponseMessge.Response
            => this;

        R IProcessResponseMessage<R, C>.Response
            => (R)this;

        object IMessage.Body
            => Content;

        string IMessage.Type
            => Content.Type;

        string IMessagePacket<string>.Payload
            => Content.ToString();

        Guid IMessagePacket.CorrelationToken
            => Content.MessageId;

        object IMessagePacket.Payload
            => Content.ToString();

        string IMessagePacket.Label
            => Content.Type;
    }
}