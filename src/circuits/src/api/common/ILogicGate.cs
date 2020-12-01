//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static SFx;

    /// <summary>
    /// Represents one (or more) logic gates, which is intended to represent
    /// a physical component that receives one or more bits of input and emits a single bit of output;
    /// i.e., boolean function reification
    /// </summary>
    public interface ILogicGate
    {

    }

    public interface ILogicGate<T> : ILogicGate
    {

    }

}