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
    /// Characterizes an operation service with an asm context where caller-managed lifecyle is not needed
    /// </summary>
    public interface IAsmService : IOpService
    {
        IAsmContext Context {get;}
    }

    /// <summary>
    /// Characterizes a disposable service with caller-managed lifecycle
    /// </summary>
    public interface IAsmServiceAllocation : IAsmService, IDisposable
    {


    }
}