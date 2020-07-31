//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWorkflowActor
    {
        Type Host {get;}

        ArtifactIdentity Id 
            => Host.MetadataToken;

        string Name
            => Host.Name;
    }
    
    public interface IWorkflowActor<F> : IWorkflowActor
        where F : struct, IWorkflowActor<F>
    {
        Type IWorkflowActor.Host 
            => typeof(F);
    }    
}