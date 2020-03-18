//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using NC = NumericClass;
    using FW = FixedWidth;

    /// <summary>
    /// Defines aspect that, when present, indicates the target is a signed integral type
    /// </summary>
    public enum SignAspect : byte
    {
        /// <summary>
        /// Signals nothing
        /// </summary>
        None = 0,        

        /// <summary>
        /// Signals signed
        /// </summary>
        Signed = 2,

    }

    /// <summary>
    /// Defines aspect that, when present, indicates the target is of floating-point kind
    /// </summary>
    public enum FloatingAspect : byte
    {
        /// <summary>
        /// Signals nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Signals float
        /// </summary>
        Float = 4,
    }

    public enum NumericWidthAspect : byte
    {
        /// <summary>
        /// Classifies numeric 1-bit types that don't exist
        /// </summary>
        W1 = (byte)FW.W1,

        /// <summary>
        /// Classifies numeric types that are 8-bits wide
        /// </summary>
        W8 = (byte)FW.W8,

        /// <summary>
        /// Classifies numeric types that are 16-bits wide
        /// </summary>
        W16 = (byte)FW.W16,

        /// <summary>
        /// Classifies numeric types that are 32-bits wide
        /// </summary>
        W32 = (byte)FW.W32,

        /// <summary>
        /// Classifies numeric types that are 64-bits wide
        /// </summary>
        W64 = (byte)FW.W64,

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
        W1 = NumericWidthAspect.W1,

        /// <summary>
        /// Classifies signed integral types; if sign bit is not enabled and float bit is not enabled, the number is considered unsigned
        /// </summary>
        Signed = SignAspect.Signed,

        /// <summary>
        /// Classifies floating-point types
        /// </summary>
        Float = FloatingAspect.Float,

        /// <summary>
        /// Classifies numeric types that are 8-bits wide
        /// </summary>
        W8 = NumericWidthAspect.W8,

        /// <summary>
        /// Classifies numeric types that are 16-bits wide
        /// </summary>
        W16 = NumericWidthAspect.W16,

        /// <summary>
        /// Classifies numeric types that are 32-bits wide
        /// </summary>
        W32 = NumericWidthAspect.W32,

        /// <summary>
        /// Classifies numeric types that are 64-bits wide
        /// </summary>
        W64 = NumericWidthAspect.W64,

        /// <summary>
        /// Classifies the conceptually useful, but practically non-extant, 1-bit unsigned integer type
        /// </summary>
        Bit = W1,

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

    public enum NumericClassId : byte
    {
        /// <summary>
        /// The nonidentifing identifier
        /// </summary>
        None = 0,

        /// <summary>
        /// Identifies the 8-bit unsigned integer type
        /// </summary>
        Int8u = NC.Int8u,       

        /// <summary>
        /// Identifies the 16-bit unsigned integer type
        /// </summary>
        Int16u = NC.Int16u,       

        /// <summary>
        /// Identifies the 32-bit unsigned integer type
        /// </summary>
        Int32u = NC.Int32u,

        /// <summary>
        /// Identifies the 64-bit unsigned integer type
        /// </summary>
        Int64u = NC.Int64u,

        /// <summary>
        /// Identifies the 8-bit signed integer type
        /// </summary>
        Int8i = NC.Int8i,       

        /// <summary>
        /// Identifies the 16-bit signed integer type
        /// </summary>
        Int16i = NC.Int16i,       

        /// <summary>
        /// Identifies the 32-bit signed integer type
        /// </summary>
        Int32i = NC.Int32i,       

        /// <summary>
        /// Identifies the 64-bit signed integer type
        /// </summary>
        Int64i = NC.Int64i,       

        /// <summary>
        /// Identifies the 32-bit floating-point type
        /// </summary>
        Float32 = NC.Float32,

        /// <summary>
        /// Identifies the 64-bit floating-point type
        /// </summary>
        Float64 = NC.Float64,
    }
}