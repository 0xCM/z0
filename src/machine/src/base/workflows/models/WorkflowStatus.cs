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

    public readonly struct WorkflowStatus
    {        
        public readonly ulong Workflow;

        public readonly ArtifactIdentity Worker;

        public readonly StringRef Description;

        public readonly ulong Correlation;

        public readonly Timestamp Timestamp;        

        [MethodImpl(Inline)]
        public WorkflowStatus(ulong id, ArtifactIdentity worker, string description)
        {
            Workflow = id;
            Description = description;
            Worker = worker;
            Correlation = 0;
            Timestamp = now();
        }

        [MethodImpl(Inline)]
        public WorkflowStatus(ulong id, ArtifactIdentity worker, string description, ulong ct, Timestamp ts)
        {
            Workflow = id;
            Description = description;
            Worker = worker;
            Correlation = ct;
            Timestamp = ts;
        }
    }
}