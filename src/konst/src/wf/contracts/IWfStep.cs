//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = AB;
    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep
    {
        WfStepId Id {get;}

        void Run(){}
    }

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep<T> : IWfStep
        where T : struct, IWfStep<T>
    {
        void Configure(params WfStepArg[] args)
            => Configure(new WfStepArgs(args));

        WfStepId IWfStep.Id
            => api.step<T>();

        void Configure(WfStepArgs args){}
    }

    public interface IWfStep<H,A,B> : IWfStep<H>
        where H : struct, IWfStep<H,A,B>
    {
        WfType<A,B> Type
            => api.type<A,B>();
    }
}