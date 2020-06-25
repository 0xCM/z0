//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    /// <summary>
    /// Defines numeric identifiers for primal numeric types
    /// </summary>
    public enum NumericTypeId : uint
    {
        None = 0,

        U8 = 1 << WidthOffset,

        I8 = 2 << WidthOffset,

        U16 = 4 << WidthOffset,

        I16 = 8 << WidthOffset,

        U32 = 16 << WidthOffset,

        I32 = 32 << WidthOffset,

        U64 = 64 << WidthOffset,

        I64 = 128 << WidthOffset,
        
        F32 = 512 << WidthOffset,

        F64 = 1024 << WidthOffset,                
    }        
}