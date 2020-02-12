//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static RootShare;

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
        Signed = NumericClass.Signed,

        /// <summary>
        /// When enabled, indicates a floating-point type
        /// </summary>
        Float = NumericClass.Float,

        /// <summary>
        /// When enabled, indicates an unsigned integral type
        /// </summary>
        Unsigned = NumericClass.Unsigned,

        /// <summary>
        /// Identifies an unsigned 8-bit integral type
        /// </summary>
        U8 = NumericId.U8 | FixedWidth.W8 | Unsigned,

        /// <summary>
        /// Identifies a signed 8-bit integral type
        /// </summary>
        I8 = NumericId.I8 | FixedWidth.W8 | Signed,

        /// <summary>
        /// Identifies an usigned 16-bit integral type
        /// </summary>
        U16 = NumericId.U16 | FixedWidth.W16 | Unsigned,

        /// <summary>
        /// Identifies a signed 16-bit integral type
        /// </summary>
        I16 = NumericId.I16 | FixedWidth.W16 | Signed,

        /// <summary>
        /// Identifies an usigned 32-bit integral type
        /// </summary>
        U32 = NumericId.U32 | FixedWidth.W32 | Unsigned, 

        /// <summary>
        /// Identifies a signed 32-bit integral type
        /// </summary>
        I32 = NumericId.I32 | FixedWidth.W32 | Signed,

        /// <summary>
        /// Identifies an usigned 64-bit integral type
        /// </summary>
        U64 = NumericId.U64 | FixedWidth.W64 | Unsigned,

        /// <summary>
        /// Identifies a signed 64-bit integral type
        /// </summary>
        I64 = NumericId.I64 | FixedWidth.W64 | Signed,

        /// <summary>
        /// Identifies a 32-bit floating-point type
        /// </summary>
        F32 = NumericId.F32 | FixedWidth.W32 | Float,
        
        /// <summary>
        /// Identifies a 64-bit floating-point type
        /// </summary>
        F64 = NumericId.F64 | FixedWidth.W64 | Float, 
        
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

    partial class RootKindExtensions
    {
        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericKind k)
            => k != 0;

        /// <summary>
        /// Determines whether kind is zero-valued
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNone(this NumericKind k)
            => k == 0;

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline),Op]
        public static string Keyword(this NumericKind k)
            => k switch {
                NK.U8 => "byte",
                NK.I8 => "sbyte",
                NK.U16 => "ushort",
                NK.I16 => "short",
                NK.U32 => "uint",
                NK.I32 => "int",
                NK.I64 => "long",
                NK.U64 => "ulong",
                NK.F32 => "float",
                NK.F64 => "double",
                 _ => throw new NotSupportedException(k.ToString())
           };

        /// <summary>
        /// Determines the primal identifer of a numeric kind
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static NumericId GetNumericId(this NumericKind k)
        {
            var noclass = ((uint)k << 3) >> 3;
            var nowidth = (noclass >> 16) << 16;
            return (NumericId)nowidth;            
        }

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static int Width(this NumericKind k)
            => (int)(ushort)k;

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth WidthKind(this NumericKind k)
            => (FixedWidth)(ushort)k;

        [MethodImpl(Inline)]
        public static NumericClass GetNumericClass(this NumericKind kind)
            => (NumericClass)((uint)kind >> 29);

        [MethodImpl(Inline)]
        public static NumericIndicator GetNumericIndicator(this NumericKind kind)
            => kind.GetNumericClass().ToNumericIndicator();

        [MethodImpl(Inline)]
        public static bool IsNumeric(this Type src)
            => src.NumericKind().IsSome();
    }
}