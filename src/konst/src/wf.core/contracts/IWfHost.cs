//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using L = WfStepLaunchers;

    public interface IWfHost : IWfStep, ITextual
    {
        Type Type {get;}

        StringRef Name {get;}

        void Run(IWfShell shell);

        string Identifier
            => Type.Name;
        string ITextual.Format()
            => Id.Format();

        L.Launch Launcher
            => Run;
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
        void Run(IWfShell wf, in S src);
    }

    public interface IWfHost<H,S,T> : IWfHost<H,S>
        where H : IWfHost<H,S,T>, new()
    {
        ref T Run(IWfShell wf, in S src, out T dst);

        void IWfHost<H,S>.Run(IWfShell wf, in S src)
            => Run(wf,src, out var _);
    }
}