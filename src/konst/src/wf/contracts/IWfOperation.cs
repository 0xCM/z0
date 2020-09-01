//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FS;

    public interface IWfOperation : ITextual
    {
        WfStepId StepId {get;}

        StringRef Name {get;}

        string ITextual.Format()
            => text.format("{0}/{1}", StepId.Format(), Name.Format());
    }


    public interface IWfFunc : IWfOperation
    {

    }

    public interface IWfAction : IWfOperation
    {
    }

    public interface IWfFunc<C> : IWfFunc
        where C : struct, IWfStep<C>
    {
        C Step => default;
    }

    public interface IWfFunc<C,R> : IWfFunc<C>
        where C : struct, IWfStep<C>
    {

    }

    public interface IWfFunc<C,A0,R> : IWfFunc<C,R>
        where C : struct, IWfStep<C>
    {

    }

    public interface IWfFunc<C,A0,A1,R> : IWfFunc<C,R>
        where C : struct, IWfStep<C>
    {

    }

    public interface IWfFunc<C,A0,A1,A2,R> : IWfFunc<C,R>
        where C : struct, IWfStep<C>
    {

    }
}