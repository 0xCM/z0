//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum PrimitiveId : uint
    {
        U8 = NumericId.U8,

        I8 = NumericId.I8,

        U16 = NumericId.U16,

        I16 = NumericId.I16,

        U32 = NumericId.U32,

        I32 = NumericId.I32,

        U64 = NumericId.U64,

        I64 = NumericId.I64,
        
        F32 = NumericId.F32,

        F64 = NumericId.F64,

        Char = 2*1024 << 16,

        Bool = 4*1024 << 16,
        
        Void = 8*1024 << 16
    }
}