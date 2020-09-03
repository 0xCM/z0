//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWfHost : ITextual
    {
        WfStepId Id {get;}

        Type Type {get;}

        StringRef Name {get;}

        void Run();

        string ITextual.Format()
            => Id.Format();
    }

    public interface IWfHost<H> : IWfHost
        where H : IWfHost<H>, new()
    {
        Type IWfHost.Type
            => typeof(H);

        WfStepId IWfHost.Id
            => typeof(H);

        StringRef IWfHost.Name
            => typeof(H).Name;
    }

    public interface IWfHost<H,C> : IWfHost
        where H : IWfHost<H,C>, new()
        where C : struct
    {
        void Configure(in C config);

        ref readonly C Config {get;}
    }

    public interface IWfHost<H,C,S,T> : IWfHost<H,C>
        where H : IWfHost<H,C,S,T>, new()
        where C : struct
        where S : struct
        where T : struct
    {
        Type IWfHost.Type
            => Type;

        new WfType<S,T> Type
            => default;

        T Run(in S src);

        void IWfHost.Run()
            => Run(new S());
    }
}