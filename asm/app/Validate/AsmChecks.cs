//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Runtime.CompilerServices;    

    using C = OpClasses;

    class AsmChecks : IAsmExecChecks
    {
        public IAsmWorkflowContext Context {get;}

        readonly IAsmEvalDispatcher Dispatcher;

        readonly IAppMsgSink MsgSink;
        
        IPolyrand Random => Context.Random;
        
        readonly int RepCount;

        public static AsmChecks Create(IAsmWorkflowContext context, IAppMsgSink sink)
            => new AsmChecks(context,sink);

        AsmChecks(IAsmWorkflowContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.RepCount = 128;
            this.MsgSink = sink;
            this.Dispatcher = AsmEvalDispatcher.Create(context, sink);
        }                

        public void Execute(in BufferSeq buffers, ApiMemberCode code)
        {
            Dispatcher.EvalOperator(buffers, code);
        }

        public void Execute(in BufferSeq buffers, ApiMemberCode[] code)
        {
            Dispatcher.EvalOperators(buffers, code);
        }

        public PairEval<T> Evaluate<T>(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOp<T> @class)
            where T : unmanaged
                => Context.Evaluate(buffers, api, @class);
    }
}