//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IAsmExecWorkflow : IExecutable
    {

    }

    public interface IAsmValidationHost : IExecutable, IDisposable
    {

    }

    public interface IAsmExecutor : IService
    {
        AsmExecResult ExecAction(Action action, OpUri f);   

        AsmExecResult ExecAction(Action action, OpUri f, OpUri g);
    }
}