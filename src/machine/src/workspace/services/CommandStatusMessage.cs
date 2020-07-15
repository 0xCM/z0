//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics.Tracing;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public sealed class CommandStatusMessage : IAppMsg
    {
        public static CommandStatusMessage Empty 
            => new CommandStatusMessage();

        public static CommandStatusMessage CreateErrorStatus(ICommandSpec spec, long? subid, string template, object content, 
            CorrelationToken? ct = null, [Caller] string messageType = null)
                => new CommandStatusMessage(spec, subid, AppMsgKind.Error, template, ct, messageType);

        CommandStatusMessage()
        {
                
        }

        internal CommandStatusMessage(ICommandSpec spec, long? subid, AppMsgKind kind, string template, CorrelationToken? ct, string MessageType)
        {
            _SubmissionId = subid;
            _Content = spec;
            _CommandName = spec.CommandName;
            _CommandSpecName = spec.SpecName;
            _Antecedent = AppMsg.Empty;
            _EventLevel = kind;
            _MessageType = MessageType;
            _Arguments = spec.Arguments;
            _MessageTemplate = template;
            _CorrelationToken = ct;
            _MessageId = Guid.NewGuid();
        }

        long? _SubmissionId { get; }

        object _Content { get; }

        string _MessageTemplate { get; }

        string _CommandName { get; }
            = "Unspecified";

        string _CommandSpecName { get; }
            = "Unspecified";

        string _MessageType { get; }
            = "Unknown";

        AppMsgKind _EventLevel { get; }
            = AppMsgKind.Info;

        IAppMsg _Antecedent { get; }

        DateTime _Timestamp { get; }
            = z.now();

        CommandArguments _Arguments { get; }
            = new CommandArguments();

        CorrelationToken? _CorrelationToken { get; }

        Guid _MessageId { get; }

        string _SourceComponent { get; }
            = string.Empty;

        public Guid MessageId
            => _MessageId;


        public IAppMsg Antecedent 
            => _Antecedent;

        public IReadOnlyList<CommandArgument> CommandArguments
            => _Arguments.ToList();

        public long? SubmissionId 
            => _SubmissionId;

        public string CommandName 
            => _CommandName;

        public string CommandSpecName
            => _CommandSpecName;

        public AppMsgKind MsgKind
            => _EventLevel;

        public bool IsEmpty
            => Object.ReferenceEquals(this, Empty);

        public string MessageCategory
            => "/Status/CommandStatus";

        public string MessageType
            => _CommandName;

        public string MessageTemplate
            => _MessageTemplate;

        public string MessageTypePath
            => Path.Combine(MessageCategory, MessageType);

        public DateTime Timestamp
            => _Timestamp;

        public object SemanticContent
            => _Content;

        public string SourceComponent
            => _SourceComponent;

        public string Format()
        {
            Func<IAppMsg, string, object, string> formatter = (msg, template, content) 
                => msg.Format();
            
            return formatter(this, _MessageTemplate, _Content);        
        }

        public string Format(bool ts)
        {
            Func<IAppMsg, string, object, string> formatter = (msg, template, content) 
                => text.concat(ts 
                    ? (z.now().ToLexicalString() + Space) 
                    : EmptyString, msg.Format());

            return formatter(this, _MessageTemplate, _Content);        
        }

        public string Format(string prepend, string postpend, bool ts)
            => (text.nonempty(prepend) ? $"{prepend} {Format(ts)}" : Format(ts))
            + (text.nonempty(postpend) ? $" {postpend}" : EmptyString);

        IAppMsg IAppMsg.AsDisplayed()
        {
            return this;
        }

        public CorrelationToken? CT
            => _CorrelationToken;

        public IEnumerable<IAppMsg> InnerMessages
            => z.seq<IAppMsg>();

        object IAppMsg.Content 
            => _Content;

        AppMsgKind IAppMsg.Kind 
            => MsgKind;

        AppMsgColor IAppMsg.Color 
            => throw new NotImplementedException();

        bool IAppMsg.Displayed 
            => false;

        bool IAppMsg.IsEmpty 
            => false;
    }   
}