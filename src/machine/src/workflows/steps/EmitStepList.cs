//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static EmitStepListStep;

    public ref struct EmitStepList
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        public WfDataFlow<Assembly,FilePath> Df;

        public EmitStepList(IWfShell wf, Assembly src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Df = (src, Wf.AppDataRoot + FileName.define(src.GetSimpleName(), "steps.json"));

            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);

            Wf.Ran(StepId);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);

        }
    }
}