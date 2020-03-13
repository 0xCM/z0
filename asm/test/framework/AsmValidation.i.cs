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

    public interface IAsmExecControl : IAsmWorkflowService
    {
        bit EvalBinaryOp(in BufferSeq buffers, ApiMemberCode api);        

        bit EvalBinaryOp(in BufferSeq buffers, ApiMemberCode[] api);
    }

    public interface IAsmExecutor : IAsmWorkflowService
    {
        AsmExecResult ExecAction(Action action, OpUri f);   

        AsmExecResult ExecAction(Action action, OpUri f, OpUri g);        

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, FixedWidth width, in ConstPair<ApiMemberCode> paired);

        HomPoints<N3,T> EvaluateOperator<T>(in BufferSeq buffers, in ApiMemberCode code, HomPoints<N2,T> src)
            where T : unmanaged;

        FixedTripleIndex<F> ExecBinaryOp<F>(in BufferSeq buffers, in ApiMemberCode code, int count)
            where F : unmanaged, IFixed;

    }
}
