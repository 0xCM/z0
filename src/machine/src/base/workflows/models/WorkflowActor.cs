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

    public readonly struct WorkflowActor<T> : IWorkflowWorker<WorkflowActor<T>>
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
        public WorkflowActor(Type host)
            => Host = host;

        ArtifactIdentity IWorkflowActor.Id
            => Id;

        Type IWorkflowActor.Host
            => Host;            

        string IWorkflowActor.Name
            => Name;
    }
}