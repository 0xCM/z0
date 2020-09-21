//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using TC = System.TypeCode;

    /// <summary>
    /// Identifies primal system types with 8-bit unsigned integers that capture
    /// the (grossly overallocated) 32-bit integer type code values. 
    /// </summary>
    public enum PrimalKindId : byte
    {
        // 0
        None = 0,

        /// <summary>
        /// 1
        /// </summary>
        Object = TC.Object,

        /// <summary>
        /// 2
        /// </summary>
        DBNull = TC.DBNull,

        /// <summary>
        /// 3
        /// </summary>
        U1 = TC.Boolean,

        /// <summary>
        /// 4
        /// </summary>
        C16 = TC.Char,
        
        /// <summary>
        /// 5
        /// </summary>
        I8 = TC.SByte,

        /// <summary>
        /// 6
        /// </summary>
        U8 = TC.Byte,

        /// <summary>
        /// 7
        /// </summary>
        I16 = TC.Int16,
        
        /// <summary>
        /// 8
        /// </summary>
        U16 = TC.UInt16,
        
        /// <summary>
        /// 9
        /// </summary>
        I32 = TC.Int32,

        /// <summary>
        /// 10
        /// </summary>
        U32 = TC.UInt32,

        /// <summary>
        /// 11
        /// </summary>
        I64 = TC.Int64,
        
        /// <summary>
        /// 12
        /// </summary>
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