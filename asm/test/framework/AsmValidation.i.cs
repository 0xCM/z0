//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static Root;
    
    public interface IValidationWorkflow : IAsmWorkflow
    {
        void Execute();
    }

    public interface IAsmChecks : IAsmWorkflowService
    {
        void Execute(in BufferSeq buffers, ApiMemberCode code);        

        void Execute(in BufferSeq buffers, ApiMemberCode[] code);        
    }

    public interface IAsmEvalDispatcher : IAsmWorkflowService
    {
        bit EvalOperator(in BufferSeq buffers, ApiMemberCode api);        

        bit EvalOperators(in BufferSeq buffers, ApiMemberCode[] api);

        bit EvalFixedOperators(in BufferSeq buffers, ApiMemberCode[] api);

        bit EvalFixedOperator(in BufferSeq buffers, in ApiMemberCode api);
    }

    public interface IAsmExecutor : IAsmWorkflowService
    {
        AsmExecResult ExecAction(Action action, OpUri f);   

        AsmExecResult ExecAction(Action action, OpUri f, OpUri g);
    }
}
