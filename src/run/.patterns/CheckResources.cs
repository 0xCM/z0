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
    using static TargetTypeStep;

    [Step(typeof(TargetType), StepName)]
    public readonly struct TargetTypeStep : IWfStep<TargetTypeStep>
    {
        public const string StepName = nameof(TargetType);

        public static WfStepId StepId => AB.step<TargetTypeStep>();
    }

    public ref struct TargetType
    {
        readonly IWfContext Wf;

        [MethodImpl(Inline)]
        public TargetType(IWfContext wf)
        {
            Wf = wf;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);
            TryRun();
            Wf.Ran(StepId);

        }

        void Execute()
        {

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