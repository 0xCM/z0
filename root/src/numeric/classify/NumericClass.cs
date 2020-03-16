//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum NumericSign : byte
    {
        None = 0,
        
        Unsigned = 0,

        Signed = 2,

    }

    [Flags]
    public enum NumericClass : byte
    {        
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies numeric 1-bit types that don't exist
        /// </summary>
        W1 = 1,

        /// <summary>
        /// Classifies signed integral types; if sign bit is not enabled and float bit is not enabled, the number is considered unsigned
        /// </summary>
        Signed = NumericSign.Signed,

        /// <summary>
        /// Classifies floating-point types
        /// </summary>
        Float = 4,

        /// <summary>
        /// Classifies numeric types that are 8-bits wide
        /// </summary>
        W8 = 8,

        /// <summary>
        /// Classifies numeric types that are 16-bits wide
        /// </summary>
        W16 = 16,

        /// <summary>
        /// Classifies numeric types that are 32-bits wide
        /// </summary>
        W32 = 32,

        /// <summary>
        /// Classifies numeric types that are 64-bits wide
        /// </summary>
        W64 = 64,

        /// <summary>
        /// Classifies the conceptually useful, but practically non-extant, 1-bit unsigned integer type
        /// </summary>
        Int1u = W1,

        /// <summary>
        /// Classifies the 8-bit unsigned integer type
        /// </summary>
        Int8u = W8,

        /// <summary>
        /// Classifies the 16-bit unsigned integer type
        /// </summary>
        Int16u = W16,

        /// <summary>
        /// Classifies the 32-bit unsigned integer type
        /// </summary>
        Int32u = W32,

        /// <summary>
        /// Classifies the 64-bit unsigned integer type
        /// </summary>
        Int64u = W64,

        /// <summary>
        /// Classifies the 8-bit signed integer type
        /// </summary>
        Int8i = Signed | W8,

        /// <summary>
        /// Classifies the 16-bit signed integer type
        /// </summary>
        Int16i = Signed | W16,

        /// <summary>
        /// Classifies the 32-bit signed integer type
        /// </summary>
        Int32i = Signed | W32,

        /// <summary>
        /// Classifies the 64-bit signed integer type
        /// </summary>
        Int64i = Signed | W64,

        /// <summary>
        /// Classifies the 32-bit floating-point type type
        /// </summary>
        Float32 = Float | W32,

        /// <summary>
        /// Classifies the 64-bit floating-point type type
        /// </summary>
        Float64 = Float | W64,

        /// <summary>
        /// Classifies all numeric type widths
        /// </summary>
        Widths = W8 | W16 | W32 | W64,

        /// <summary>
        /// Classifies signed integral types
        /// </summary>
        SignedInts = Int8i | Int16i | Int32i | Int64i,

        /// <summary>
        /// Classifies unsigned integral types
        /// </summary>
        UnsignedInts = Int8u | Int16u | Int32u | Int64u,

        /// <summary>
        /// Classifies floating-point types
        /// </summary>
        Floats = Float32 | Float64,

        /// <summary>
        /// Classifies integral types
        /// </summary>
        Integers = SignedInts | UnsignedInts,

        /// <summary>
        /// Classifies all numeric types
        /// </summary>
        All = Integers | Floats,
    }

}