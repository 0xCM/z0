//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;

    using C = OpClass;

    public interface IAsmWorkflow : IService
    {
        void Run();
        
    }

    public interface IAsmExecWorkflow : IAsmWorkflow
    {
        
    }

    public interface IAsmValidationHost : IAsmWorkflow, IDisposable
    {
        
    }

    public interface IAsmExecutor : IAsmService
    {
        AsmExecResult ExecAction(Action action, OpUri f);   

        AsmExecResult ExecAction(Action action, OpUri f, OpUri g);
    }

    interface IAsmExecChecks : IAsmService
    {
        void Execute(in BufferSeq buffers, ApiMemberCode code);        

        void Execute(in BufferSeq buffers, ApiMemberCode[] code);        

        BinaryEval<T> Evaluate<T>(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOp<T> @class)
            where T : unmanaged;        
    }
}