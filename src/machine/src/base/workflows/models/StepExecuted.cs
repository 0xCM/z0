//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public readonly struct StepExecuted
    {
        public readonly ulong Workflow;

        public readonly ArtifactIdentity Worker;

        public readonly StringRef StepName;

        public readonly ulong Correlation;        

        public readonly Timestamp Timestamp;            

        [MethodImpl(Inline)]
        public StepExecuted(ulong workflow, ArtifactIdentity worker, string step, ulong ct)
        {
            Workflow = workflow;
            Worker = worker;
            StepName = step;
            Timestamp = now();
            Correlation = ct;
        }

        [MethodImpl(Inline)]
        public StepExecuted(ulong workflow, ArtifactIdentity worker, string step, ulong ct, Timestamp ts)
        {
            Workflow = workflow;
            Worker = worker;
            StepName = step;
            Timestamp = ts;
            Correlation = ct;
        }
    }
}