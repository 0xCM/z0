//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [WfHost]
    public sealed class CheckResources : WfHost<CheckResources>
    {
        public const string StepName = nameof(CheckResourcesStep);

        protected override void Execute(IWfShell wf)
        {
            var src = FS.path("J:/dev/projects/z0-logs/builds/respack/lib/netcoreapp3.1/z0.respack.dll");
            using var step = new CheckResourcesStep(wf,this,src);
            step.Run();
        }
    }

    public ref struct CheckResourcesStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly FS.FilePath Source;

        [MethodImpl(Inline)]
        public CheckResourcesStep(IWfShell wf, WfHost host, FS.FilePath src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Wf.Created(Host);
        }

        public void Run()
        {
            var flow = Wf.Running(Host);
            TryRun();
            Wf.Ran(flow, Host);
        }

        void Execute()
        {
            using var map = MemoryFiles.map(Source);
            var @base = map.BaseAddress;
            var sig = map.View(0, 2).AsUInt16();
            Wf.Status(Host, map.Description);
        }

        void TryRun()
        {
            try
            {
                Execute();
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}