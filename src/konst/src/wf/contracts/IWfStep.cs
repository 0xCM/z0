//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = AB;

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep
    {
        WfStepId Id {get;}
    }


    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep<T> : IWfStep
        where T : struct, IWfStep<T>
    {
        WfStepId IWfStep.Id
            => api.step<T>();
    }
}