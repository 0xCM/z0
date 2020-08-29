//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static CheckResourcesStep;

    [Step(typeof(CheckResources))]
    public readonly struct CheckResourcesStep : IWfStep<CheckResourcesStep>
    {
        public const string StepName = nameof(CheckResources);

        public static WfStepId StepId => AB.step<CheckResourcesStep>();
    }

    public ref struct CheckResources
    {
        readonly IWfContext Wf;

        readonly FS.FilePath Source;


        [MethodImpl(Inline)]
        public CheckResources(IWfContext wf)
        {
            Wf = wf;
            Wf.Created(StepId);
            Source = FS.path("J:/dev/projects/z0-logs/builds/respack/lib/netcoreapp3.1/z0.respack.dll");
        }

        public void Run()
        {
            Wf.Running(StepId);
            TryRun();
            Wf.Ran(StepId);
        }

        void Execute()
        {
            using var map = MemoryFile.open(Source);
            var @base = map.BaseAddress;
            var sig = map.Read(@base, 2).AsUInt16();
            var magic = Z0.Image.PeLiterals.Magical;
            var info = map.Description.Description;;
            Wf.Status(StepId, info);
        }

        void TryRun()
        {
            try
            {
                Execute();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}