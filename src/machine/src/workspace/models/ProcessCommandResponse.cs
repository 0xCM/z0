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
        public static implicit operator ProcessCommandResponseAdapter(ProcessComandResponse<R,C> response)
            => new ProcessCommandResponseAdapter(new ProcessCommandAdapter(response.Command), response);
            
        protected ProcessComandResponse(C command, ProcessMessage content)
        {
            this.Command = command;
            this.Content = content ?? ProcessMessage.Empty(command.CommandName);
        }

        protected ProcessComandResponse(C command, IMessage content)
        {
            this.Command = command;
            this.Content = content as ProcessMessage ?? ProcessMessage.Empty(command.CommandName);
        }

        public ProcessMessage Content {get;}

        Guid IMessage.MessageId
            => Content.MessageId;


        public override string ToString()
            => Content.ToString();

        string IMessage.ToCanonicalForm()
            => Content.ToCanonicalForm();

        public C Command { get; }


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

    public abstract class ProcessCommandResponse<c> : ProcessComandResponse<ProcessCommandResponse<c>, c>
        where c : IProcessCommand
    {       
        public ProcessCommandResponse(c command, IProcessResponseMessge adapted_response)
            : base(command, adapted_response)
        {
            this.adapted_response = adapted_response;
            
        }

        IProcessResponseMessge adapted_response { get; }
    }
}