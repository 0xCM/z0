//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;

    public interface IThreadHelpers
    {
        IDataReader DataReader { get; }
    
        ITypeFactory Factory { get; }
    
        IExceptionHelpers ExceptionHelpers { get; }

        IEnumerable<ClrStackRoot> EnumerateStackRoots(ClrThread thread);
    
        IEnumerable<ClrStackFrame> EnumerateStackTrace(ClrThread thread, bool includeContext);
    }   
}