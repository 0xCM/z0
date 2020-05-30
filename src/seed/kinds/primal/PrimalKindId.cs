//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using TC = System.TypeCode;

    /// <summary>
    /// Identifies primal system types with 8-bit unsigned integers that capture
    /// the (grossly overallocated) 32-bit integer type code values. 
    /// </summary>
    public enum PrimalKindId : byte
    {
        // 1
        Object = TC.Object,

        // 2
        DBNull = TC.DBNull,

        // 3
        U1 = TC.Boolean,

        // 4
        Char16 = TC.Char,
        
        // 5
        I8 = TC.SByte,

        // 6
        U8 = TC.Byte,

        // 7
        I16 = TC.Int16,
        
        // 8
        U16 = TC.UInt16,
        
        // 9
        I32 = TC.Int32,

        // 10        
        U32 = TC.UInt32,

        // 11
        I64 = TC.Int64,
        
        // 12
        U64 = TC.UInt64,

        // 13
        F32 = TC.Single,
        
        // 14
        F64 = TC.Double,
        
        // 15
        F128 = TC.Decimal,

        // 16
        DateTime = TC.DateTime,

        // 18
        String = TC.String
    }

}