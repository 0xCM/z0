//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static root;

    using C = OpClass;

    public interface IAsmExecWorkflow : IAsmService
    {
        void Run();
    }

    public interface IAsmValidationHost : IAsmService, IDisposable
    {
        void Run();
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