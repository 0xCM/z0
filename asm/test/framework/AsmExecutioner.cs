//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;
    
    class AsmExecutioner : IAsmExecutioner
    {
        
        public IAsmWorkflowContext Context {get;}

        readonly IAppMsgSink Sink;

        public static IAsmExecutioner Create(IAsmWorkflowContext context, IAppMsgSink sink)
            => new AsmExecutioner(context,sink);

        AsmExecutioner(IAsmWorkflowContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.Sink = sink;
        }

        public void Publish(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public void Publish(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);


        public void CheckExecution(ApiMemberCode code)
        {
            var kind = code.Member.KindId;
            kind.OnSome(k => CheckExecution(k, code.Member, code.Code));            
        }

        
        public void CheckExecution(OpKindId kind, HostedMember member, BinaryCode code)
        {
            Sink.ValidatingExecution(member.Uri);
            switch(kind)
            {
                case OpKindId.And:
                    break;
                default:
                    break;
            }
        }

    }
}