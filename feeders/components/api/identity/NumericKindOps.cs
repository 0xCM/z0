//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;
    using static NumericKind;
    using NK = NumericKind;
    
    partial class ComponentOps
    {
        public static NumericKind NumericKind(this Type src)
            => SystemNumeric.kind(src);

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this TypeCode tc)
            => SystemNumeric.kind(tc);

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericKind k)
            => k != 0;

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsFloat(this NumericKind k)
            => (k & NK.Float) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsSigned(this NumericKind k)
            => (k & NK.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NumericKind k)
            => (k & NK.Unsigned) != 0;        

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static NumericIndicator Indicator(this NumericKind k)
        {
            if(k.IsUnsigned())
                return NumericIndicator.Unsigned;
            else if(k.IsSigned())
                return NumericIndicator.Signed;
            else if(k.IsFloat())
                return NumericIndicator.Float;
            else
                return NumericIndicator.None;
        }

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static int Width(this NumericKind k)
            => (int)(ushort)k;

        [MethodImpl(Inline)]
        public static string Format(this NumericKind k)
            => $"{k.Width()}{k.Indicator().Format()}";

        /// <summary>
        /// Determines the primal identifer of a numeric kind
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static NumericTypeId GetNumericId(this NumericKind k)
        {
            var noclass = ((uint)k << 3) >> 3;
            var nowidth = (noclass >> 16) << 16;
            return (NumericTypeId)nowidth;            
        }

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static TypeWidth TypeWidth(this NumericKind k)
            => (TypeWidth)(ushort)k; 

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        public static Type SystemType(this NumericKind src)
            => src switch {
                U8 => typeof(byte),
                I8 => typeof(sbyte),
                U16 => typeof(ushort),
                I16 => typeof(short),
                U32 => typeof(uint),
                I32 => typeof(int),
                I64 => typeof(long),
                U64 => typeof(ulong),
                F32 => typeof(float),
                F64 => typeof(double),
                _ => typeof(void)
            };

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        public static string Keyword(this NumericKind k)
            => k switch {
                U8 => "byte",
                I8 => "sbyte",
                U16 => "ushort",
                I16 => "short",
                U32 => "uint",
                I32 => "int",
                I64 => "long",
                U64 => "ulong",
                F32 => "float",
                F64 => "double",
                 _ => throw new NotSupportedException(k.ToString())
           };

    }
}