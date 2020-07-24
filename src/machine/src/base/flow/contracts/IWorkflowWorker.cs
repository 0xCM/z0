//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWorkflowWorker
    {
        Type Host {get;}
        
        ArtifactIdentity Id 
            => Host.MetadataToken;

        string Name
            => Host.Name;
    }

    public interface IWorkflowWorker<F> : IWorkflowWorker
        where F : struct, IWorkflowWorker<F>
    {
        Type IWorkflowWorker.Host 
            => typeof(F);
    }
}