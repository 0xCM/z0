//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static NumericKind;
    using PId = PrimalId;

    partial class RootX
    {
        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Width(this NumericKind k)
            => k switch {
                Z0.NumericKind.U8 => 8,
                Z0.NumericKind.I8 => 8,
                Z0.NumericKind.U16 => 16,
                Z0.NumericKind.I16 => 16,
                Z0.NumericKind.U32 => 32,
                Z0.NumericKind.I32 => 32,
                Z0.NumericKind.I64 => 64,
                Z0.NumericKind.U64 => 64,
                Z0.NumericKind.F32 => 32,
                Z0.NumericKind.F64 => 64,
                _ => 0
            };

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FixedWidth WidthKind(this NumericKind k)
            => (FixedWidth)(ushort)k;

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        static Type ToPrimalType(this NumericKind k)
            => k switch {
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
                _ => throw new NotSupportedException(k.ToString())
            };

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSome(this NumericKind k)
            => k != None;

        /// <summary>
        /// Determines the primal identifer of a numeric kind
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static PrimalId GetPrimalId(this NumericKind k)
            => (PrimalId)((((uint)k << 8) >> 24) << 16);

        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NumericKind match)        
            => ((uint)k & (uint)match) != 0;

        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, PrimalId match)        
            => ((uint)k & (uint)match) != 0;

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static IEnumerable<NumericKind> DistinctKinds(this NumericKind k)       
        {
            if(k.Is(PrimalId.U8))
                yield return U8;

            if(k.Is(PrimalId.I8))
                yield return I8;

            if(k.Is(PrimalId.U16))
                yield return U16;

            if(k.Is(PrimalId.I16))
                yield return I16;

            if(k.Is(PrimalId.U32))
                yield return U32;

            if(k.Is(PrimalId.I32))
                yield return I32;

            if(k.Is(PrimalId.U64))
                yield return U64;

            if(k.Is(PrimalId.I64))
                yield return I64;

            if(k.Is(PrimalId.F32))
                yield return F32;

            if(k.Is(PrimalId.F64))
                yield return F64;
        }

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static IEnumerable<Type> PrimalTypes(this NumericKind k)
            => k.DistinctKinds().Select(x => x.ToPrimalType());         
 
        /// <summary>
        /// Determines whether the type is a (memory) reference
        /// </summary>
        /// <param name="src">The type to examine</param>
        static bool IsRef(this Type src)
            => src.UnderlyingSystemType.IsByRef;

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        static Type EffectiveType(this Type src)
            =>  src.IsRef() ? src.GetElementType() : src;
 
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this Type t)
            => Type.GetTypeCode(t.EffectiveType()) 
            switch
            {
                TypeCode.Byte => U8,
                TypeCode.SByte => I8,
                TypeCode.Int16 => I16,
                TypeCode.UInt16 => U16,
                TypeCode.Int32 => I32,
                TypeCode.UInt32 => U32,
                TypeCode.Int64 => I64,
                TypeCode.UInt64 => U64,
                TypeCode.Single => F32,
                TypeCode.Double => F64,
                _ => None
            };

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
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