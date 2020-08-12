//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    public interface IFieldData
    {
        IFieldHelpers Helpers { get; }

        ClrElementType ElementType { get; }
        
        int Token { get; }
        
        int Offset { get; }
        
        ulong TypeMethodTable { get; }
    }
}