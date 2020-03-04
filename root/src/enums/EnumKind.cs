//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    using TC = System.TypeCode;

    public enum EnumKind : byte
    {
        None = 0,

        I8 = TC.SByte,

        U8 = TC.Byte,

        I16 = TC.Int16,

        U16 = TC.UInt16,

        I32 = TC.Int32,

        U32 = TC.UInt32,

        I64 = TC.Int64,

        U64 = TC.UInt64
    }
}