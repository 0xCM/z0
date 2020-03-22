//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    using static Root;

    using NK = NumericKind;
    using NI = NumericIndicator;

    partial class RootNumericOps
    {
       [MethodImpl(Inline)]
        public static string Format(this NK k)
            => $"{k.Width()}{k.Indicator().Format()}";

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        public static Option<Type> ToClrType(this NumericKind src)
        {
            var t = src switch {
                NK.U8 => typeof(byte),
                NK.I8 => typeof(sbyte),
                NK.U16 => typeof(ushort),
                NK.I16 => typeof(short),
                NK.U32 => typeof(uint),
                NK.I32 => typeof(int),
                NK.I64 => typeof(long),
                NK.U64 => typeof(ulong),
                NK.F32 => typeof(float),
                NK.F64 => typeof(double),
                _ => typeof(void)
            };
            return t.IsSome() ? some(t) : none<Type>();
        }


        // [MethodImpl(Inline)]
        // public static Option<Type> ToClrType(this NK k)
        //     => from nt in NT.From(k) select nt.Subject;

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NK k)
            => k != 0;

        /// <summary>
        /// Determines whether kind is zero-valued
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNone(this NK k)
            => k == 0;

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline),Op]
        public static string Keyword(this NK k)
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
        public static NumericKindId GetNumericId(this NK k)
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
        public static int Width(this NK k)
            => (int)(ushort)k;

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth WidthKind(this NK k)
            => (FixedWidth)(ushort)k; 

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NK k, NumericKindId match)        
            => NumericIdentity.contains(k,match);

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NK> DistinctKinds(this NK k)  
            => NumericIdentity.kindset(k);    

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsFloat(this NK k)
            => (k & NK.Float) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsSigned(this NK k)
            => (k & NK.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NK k)
            => (k & NK.Unsigned) != 0;        

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static NI Indicator(this NK k)
        {
            if(k.IsUnsigned())
                return NI.Unsigned;
            else if(k.IsSigned())
                return NI.Signed;
            else if(k.IsFloat())
                return NI.Float;
            else
                return NI.None;
        }
    }
}