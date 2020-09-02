//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using api = AB;

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep
    {
        WfStepId Id {get;}

        string Name
            => Id.Control.Name.Remove("Step");

        WfFunc<C> Fx<C>([CallerMemberName] string name = null)
            where C : struct, IWfStep<C>
                => new WfFunc<C>(name);
    }

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep<C> : IWfStep
        where C : struct, IWfStep<C>
    {
        WfStepId IWfStep.Id
            => api.step<C>();

        WfFunc<C> Fx([CallerMemberName] string name = null)
            => new WfFunc<C>(name);
    }
}