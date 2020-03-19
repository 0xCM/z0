//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    using C = Classes;

    public interface IAsmExecWorkflow : IAsmWorkflow
    {
        void Run();
    }

    public interface IAsmValidationHost : IAsmWorkflowService, IDisposable
    {
        void Run();
    }


    public interface IAsmExecutor : IAsmWorkflowService
    {
        AsmExecResult ExecAction(Action action, OpUri f);   

        AsmExecResult ExecAction(Action action, OpUri f, OpUri g);
    }

    interface IAsmExecChecks : IAsmWorkflowService
    {
        void Execute(in BufferSeq buffers, ApiMemberCode code);        

        void Execute(in BufferSeq buffers, ApiMemberCode[] code);        

        BinaryEval<T> Evaluate<T>(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOp<T> @class)
            where T : unmanaged;        
    }
}