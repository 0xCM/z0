//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Step(typeof(LogOpCodes))]
    public struct LogOpCodesArgs : IWfStepArgs
    {
        public const string StepName = nameof(LogOpCodesArgs);

        public FS.FilePath Target;

        public readonly WfStepId StepId;

        public LogOpCodesArgs(FS.FilePath target)
        {
            Target = target;
            StepId = AB.step(typeof(LogOpCodesArgs));
        }
    }
}