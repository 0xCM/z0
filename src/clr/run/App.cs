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
        using var wf = WfCore.shell(args);
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

        // using var tools = new Tools(Wf);


        // var tool = tools.ildasm("-bytes", "-raweh", "-tokens", "-forward", "-typelist", "-headers", "-stats", "-classlist", "-metadata=raw", @"j:\dev\projects\z0\.build\bin\netcoreapp3.1\z0.dvec.dll", @"-out=j:\dev\projects\z0-logs\tools\ildasm\z0.dvec.dll.raw.il");
        // var result = tools.Run(tool);


        //Wf.Status(Id, tool);


        Wf.Ran(Id, Part);
    }
}
