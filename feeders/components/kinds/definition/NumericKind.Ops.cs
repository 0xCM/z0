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

    public static class NumericKindOps
    {
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


        /// <summary>
        /// Determines the primal identifer of a numeric kind
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static NumericKindId GetNumericId(this NumericKind k)
        {
            var noclass = ((uint)k << 3) >> 3;
            var nowidth = (noclass >> 16) << 16;
            return (NumericKindId)nowidth;            
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

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NumericKindId match)        
            => NumericTypes.contains(k, match);

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsFloat(this NumericKind k)
            => (k & NumericKind.Float) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsSigned(this NumericKind k)
            => (k & NumericKind.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NumericKind k)
            => (k & NumericKind.Unsigned) != 0;        

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
    }    
}