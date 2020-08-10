//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static Konst;

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep
    {
        string StepName {get;}

        WfStepId StepId {get;}
    }

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep<T> : IWfStep
        where T : struct, IWfStep<T>
    {
        string IWfStep.StepName 
            => typeof(T).LiteralFieldValue<string>(nameof(StepName), EmptyString);
    }

    /// <summary>
    /// Describes a workflow step
    /// </summary>
    public interface IWfStep<T,K> : IWfStep<T>
        where T : struct, IWfStep<T,K>
        where K : unmanaged, Enum
    {        
        K StepKind
            => typeof(T).LiteralFieldValue<K>(nameof(StepKind));        
        
        WfStepId IWfStep.StepId 
            => new WfStepId(z.@as<K,ulong>(StepKind), StepName);
    }
}