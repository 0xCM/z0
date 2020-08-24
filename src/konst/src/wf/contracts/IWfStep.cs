//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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

        void Configure(WfStepArgs args){}
    }
}