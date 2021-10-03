//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public interface IMachine
    {

    }

    public interface IMachine<T> : IMachine
    {

    }

    public abstract class Machine<T> : IMachine
        where T : Machine<T>
    {

    }

    /// <summary>
    /// Random access machine
    /// </summary>
    public abstract class RAM<T> : Machine<RAM<T>>
        where T : RAM<T>, new()
    {

    }

    /// <summary>
    /// Parallel Random access machine
    /// </summary>
    public abstract class PRAM<T> : Machine<PRAM<T>>
        where T : PRAM<T>, new()
    {

    }

    public readonly struct Machine
    {


    }
}