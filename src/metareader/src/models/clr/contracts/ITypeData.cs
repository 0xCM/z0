//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface ITypeData
    {
        bool IsShared { get; }
    
        bool ContainsPointers { get; }
    
        int Token { get; }
    
        ulong MethodTable { get; }
    
        // Currently no runtime emits this, but opportunistically I'd like to see it work.
        ulong ComponentMethodTable { get; }
    
        int BaseSize { get; }
    
        int ComponentSize { get; }
    
        int MethodCount { get; }

        ITypeHelpers Helpers { get; }
    }
}