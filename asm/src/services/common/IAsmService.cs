//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using AsmSpecs;

    using static zfunc;

    /// <summary>
    /// Characterizes a contextual asm service where caller-managed lifecyle is not needed
    /// </summary>
    public interface IAsmService : IOpService
    {
        IAsmContext Context {get;}
    }

    /// <summary>
    /// Characterizes contexutal asm service with caller-managed lifecycle
    /// </summary>
    public interface IAsmServiceAllocation : IAsmService, IDisposable
    {


    }
}