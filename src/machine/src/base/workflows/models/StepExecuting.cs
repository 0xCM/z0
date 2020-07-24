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

    public readonly struct StepExecuting
    {        
        public readonly ulong Workflow;

        public readonly ArtifactIdentity Worker;

        public readonly StringRef StepName;

        public readonly ulong Correlation;        

        public readonly Timestamp Timestamp;            

        [MethodImpl(Inline)]
        public StepExecuting(ulong wfid, ArtifactIdentity worker, string step, ulong ct, Timestamp ts)
        {
            Workflow = wfid;
            Worker = worker;
            StepName = step;
            Correlation = ct;
            Timestamp = ts;
        }

        [MethodImpl(Inline)]
        public StepExecuting(ulong workflow, ArtifactIdentity worker, string step, ulong ct)
        {
            Workflow = workflow;
            Worker = worker;
            StepName = step;
            Correlation = ct;
            Timestamp = now();
        }
    }
}