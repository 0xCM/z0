//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines identifier literals for system-defined primal types
    /// </summary>
    public enum PrimitiveId : uint
    {
        U8 = NumericKindId.U8,

        I8 = NumericKindId.I8,

        U16 = NumericKindId.U16,

        I16 = NumericKindId.I16,

        U32 = NumericKindId.U32,

        I32 = NumericKindId.I32,

        U64 = NumericKindId.U64,

        I64 = NumericKindId.I64,
        
        F32 = NumericKindId.F32,

        F64 = NumericKindId.F64,

        Char = 2*1024 << 16,

        Bool = 4*1024 << 16,
        
        Void = 8*1024 << 16
    }
}