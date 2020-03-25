//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using DW = DataWidth;
    using ID = NumericTypeId;
    using TC = System.TypeCode;
    using NK = NumericKind;

    /// <summary>
    /// Clasifies system-defined numeric primitive types
    /// </summary>
    [Flags]
    public enum NumericKind : uint
    {    
        None = 0,
        
        /// <summary>
        /// When enabled, indicates a signed integral type
        /// </summary>
        Signed = 1u << 31,

        /// <summary>
        /// When enabled, indicates a floating-point type
        /// </summary>
        Float = 1u << 30,

        /// <summary>
        /// When enabled, indicates an unsigned integral type
        /// </summary>
        Unsigned = 1u << 29,

        /// <summary>
        /// Identifies an unsigned 8-bit integral type
        /// </summary>
        U8 = ID.U8 | DW.W8 | Unsigned,

        /// <summary>
        /// Identifies a signed 8-bit integral type
        /// </summary>
        I8 = ID.I8 | DW.W8 | Signed,

        /// <summary>
        /// Identifies an usigned 16-bit integral type
        /// </summary>
        U16 = ID.U16 | DW.W16 | Unsigned,

        /// <summary>
        /// Identifies a signed 16-bit integral type
        /// </summary>
        I16 = ID.I16 | DW.W16 | Signed,

        /// <summary>
        /// Identifies an usigned 32-bit integral type
        /// </summary>
        U32 = ID.U32 | DW.W32 | Unsigned, 

        /// <summary>
        /// Identifies a signed 32-bit integral type
        /// </summary>
        I32 = ID.I32 | DW.W32 | Signed,

        /// <summary>
        /// Identifies an usigned 64-bit integral type
        /// </summary>
        U64 = ID.U64 | DW.W64 | Unsigned,

        /// <summary>
        /// Identifies a signed 64-bit integral type
        /// </summary>
        I64 = ID.I64 | DW.W64 | Signed,

        /// <summary>
        /// Identifies a 32-bit floating-point type
        /// </summary>
        F32 = ID.F32 | DW.W32 | Float,
        
        /// <summary>
        /// Identifies a 64-bit floating-point type
        /// </summary>
        F64 = ID.F64 | DW.W64 | Float, 
        
        /// <summary>
        /// Defines a classification that includes all signed primal integral types and no others
        /// </summary>
        SignedInts = I8 | I16 | I32 | I64,

        /// <summary>
        /// Defines a classification that includes all unsigned primal integral types and no others
        /// </summary>        
        UnsignedInts = U8 | U16 | U32 | U64,

        /// <summary>
        /// Defines a classification that includes all primal integral types and no others
        /// </summary>
        Integers = SignedInts | UnsignedInts,

        /// <summary>
        /// Defines a classification that includes all primal floating-point types and no others
        /// </summary>
        Floats = F32 | F64,

        /// <summary>
        /// Defines a classification that includes all kinds
        /// </summary>
        All = Integers | Floats,

        /// <summary>
        /// Defines a classification that includes kinds of width 8
        /// </summary>
        Width8 = U8 | I8,

        /// <summary>
        /// Defines a classification that includes kinds of width 16
        /// </summary>
        Width16 = U16 | I16,

        /// <summary>
        /// Defines a classification that includes kinds of width 32
        /// </summary>
        Width32 = U32 | I32 | F32,

        /// Defines a classification that includes kinds of width 64
        /// </summary>
        Width64 = U64 | I64 | F64
    }

    /// <summary>
    /// Defines numeric identifiers for primal numeric types
    /// </summary>
    public enum NumericTypeId : uint
    {
        None = 0,

        U8 = (1u << 16),

        I8 = (2u << 16),

        U16 = 4u << 16,

        I16 = 8u << 16,

        U32 = 16u << 16,

        I32 = 32u << 16,

        U64 = 64u << 16,

        I64 = 128u << 16,
        
        F32 = 512u << 16,

        F64 = 1024u << 16,
    }        

    public static class SystemNumeric
    {
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static NumericKind kind(Type t)
        {
            var k = t.IsEnum 
                ? NumericKind.None 
                : Type.GetTypeCode(t.EffectiveType()) 
                switch
                {
                    TC.SByte => NK.I8,
                    TC.Byte => NK.U8,
                    TC.Int16 => NK.I16,
                    TC.UInt16 => NK.U16,
                    TC.Int32 => NK.I32,
                    TC.UInt32 => NK.U32,
                    TC.Int64 => NK.I64,
                    TC.UInt64 => NK.U64,
                    TC.Single => NK.F32,
                    TC.Double => NK.F64,
                    _ => NK.None
                };
            return k;
        }

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [Op]
        public static NumericKind kind(TypeCode tc)
        {
            switch(tc)
            {
                case TC.SByte:
                    return NK.I8;

                case TC.Byte:
                    return NK.U8;

                case TC.Int16:
                    return NK.I16;

                case TC.UInt16:
                    return NK.U16;
                
                case TC.Int32:
                    return NK.I32;

                case TC.UInt32:
                    return NK.U32;

                case TC.Int64:
                    return NK.I64;

                case TC.UInt64:
                    return NK.U64;

                case TC.Single:
                    return NK.F32;

                case TC.Double:
                    return NK.F64;
            }
            
            return NK.None;
        }
    }    
}