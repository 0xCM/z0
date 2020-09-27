//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;
        
    public interface IExceptionHelpers
    {
        ImmutableArray<ClrStackFrame> GetExceptionStackTrace(ClrThread thread, ClrObject obj);
    }
}