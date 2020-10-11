//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using Z0;

ref struct Runner
{
    readonly IWfShell Wf;

    readonly WfStepId Id;

    public const PartId Part = PartId.ClrRun;

    Span<string> Args;

    public static int Main(params string[] args)
    {
        using var wf = WfShell.create(args);
        using var runner = new Runner(wf,args);
        runner.Run();
        return 0;
    }

    public void Dispose()
    {
        Wf.Disposed(Id, Part);

    }

    public Runner(IWfShell wf, string[] args)
    {
        Wf = wf;
        Args = args;
        Id = typeof(Runner);
        Wf.Created(Id, Part);

    }

    public void Run()
    {
        Wf.Running(Id, Part);

        EmitEnums.run(Wf);
        EmitClrHandles.run(Wf);
        Wf.Ran(Id, Part);
    }
}
