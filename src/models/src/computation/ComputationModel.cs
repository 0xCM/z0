//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.Computation
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public interface IComputationModel
    {

    }

    public interface IComputationModel<T> : IComputationModel
    {

    }

    public abstract class ComputationModel<T> : IComputationModel
        where T : ComputationModel<T>
    {

    }

    /// <summary>
    /// Random access machine
    /// </summary>
    public abstract class RAM<T> : ComputationModel<RAM<T>>
        where T : RAM<T>, new()
    {

    }

    /// <summary>
    /// Parallel Random access machine
    /// </summary>
    public abstract class PRAM<T> : ComputationModel<PRAM<T>>
        where T : PRAM<T>, new()
    {

    }
}