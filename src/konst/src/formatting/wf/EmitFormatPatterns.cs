//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitFormatPatternsStep;


    [Step(typeof(EmitFormatPatterns))]
    public readonly struct EmitFormatPatternsStep : IWfStep<EmitFormatPatternsStep>
    {
        public static WfStepId StepId
            => AB.step<EmitFormatPatternsStep>();
    }

    public ref struct EmitFormatPatterns
    {
        readonly IWfShell Wf;

        public readonly WfStepId Step;

        public WfDataFlow<Type,FS.FilePath> Df;

        [MethodImpl(Inline)]
        public EmitFormatPatterns(IWfShell wf, WfDataFlow<Type,FS.FilePath> df)
        {
            Wf = wf;
            Step = StepId;
            Df = df;
            Wf.Created(Step);
        }

        public void Run()
        {
            Wf.Running(Step);

            try
            {
                var patterns = RenderPatterns.index(Df.Source);
                foreach(var pattern in patterns.View)
                    Wf.Status(Step, pattern.Format());

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(Step);
        }

        public void Dispose()
        {
            Wf.Finished(Step);
        }
    }
}