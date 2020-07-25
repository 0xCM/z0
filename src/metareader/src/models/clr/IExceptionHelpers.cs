//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    
    partial struct ClrDataModel
    {
        public interface IExceptionHelpers
        {
            ImmutableArray<ClrStackFrame> GetExceptionStackTrace(ClrThread thread, ClrObject obj);
        }
    }
}