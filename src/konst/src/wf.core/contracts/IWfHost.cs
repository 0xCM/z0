//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWfHost : IWfStep, ITextual
    {
        Type Type {get;}

        StringRef Name {get;}

        void Run(IWfShell shell);

        string ITextual.Format()
            => Id.Format();
    }

    public interface IWfHost<H> : IWfHost, IWfStep<H>
        where H : IWfHost<H>, new()
    {
        Type IWfHost.Type
            => typeof(H);

        WfStepId IWfStep.Id
            => typeof(H);

        StringRef IWfHost.Name
            => typeof(H).Name;
    }

    public interface IWfHost<H,S> : IWfHost<H>
        where H : IWfHost<H,S>, new()
    {
        void Run(IWfShell wf, S state);
    }
}