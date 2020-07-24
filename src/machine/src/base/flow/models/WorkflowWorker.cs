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

    public readonly struct WorkflowWorker<T> : IWorkflowWorker<WorkflowWorker<T>>
    {
        public readonly Type Host;

        public ArtifactIdentity Id
        {
            [MethodImpl(Inline)]
            get => Host.MetadataToken;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Host.Name;
        }
        
        [MethodImpl(Inline)]
        public WorkflowWorker(Type host)
            => Host = host;

        ArtifactIdentity IWorkflowWorker.Id
            => Id;

        Type IWorkflowWorker.Host
            => Host;            

        string IWorkflowWorker.Name
            => Name;
    }
}