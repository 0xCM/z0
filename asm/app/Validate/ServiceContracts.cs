//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;

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

    public interface IAsmExecutor : IService
    {
        AsmExecResult ExecAction(Action action, OpUri f);   

        AsmExecResult ExecAction(Action action, OpUri f, OpUri g);
    }
}