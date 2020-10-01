//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using api = WfCore;

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep
    {
        WfStepId Id {get;}

        WfFunc<C> Fx<C>([CallerMemberName] string name = null)
            where C : struct, IWfStep<C>
                => new WfFunc<C>(name);
    }

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep<C> : IWfStep
        where C : IWfStep<C>, new()
    {
        WfStepId IWfStep.Id
            => api.step<C>();

        WfFunc<C> Fx([CallerMemberName] string name = null)
            => new WfFunc<C>(name);
    }
}