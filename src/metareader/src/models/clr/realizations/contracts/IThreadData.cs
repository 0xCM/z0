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

    public interface IThreadData
    {
        IThreadHelpers Helpers { get; }
    
        ulong Address { get; }
    
        bool IsFinalizer { get; }
    
        uint OSThreadID { get; }
    
        int ManagedThreadID { get; }
    
        uint LockCount { get; }
    
        int State { get; }
    
        ulong ExceptionHandle { get; }
    
        bool Preemptive { get; }
    
        ulong StackBase { get; }
    
        ulong StackLimit { get; }
    }    
}