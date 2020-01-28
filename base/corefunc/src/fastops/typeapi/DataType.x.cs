//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class DataTypeX
    {
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Type ToPrimalType(this NumericKind k)
            => PrimalType.type(k);

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericKind k)
            => k != NumericKind.None;

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static string Keyword(this NumericKind k)
            => PrimalType.keyword(k);

        /// <summary>
        /// Specifies the bit-width of a classified primitive
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this NumericKind k)
            => PrimalType.width(k);

        /// <summary>
        /// Determines the kind identifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static PrimalId Id(this NumericKind kind)
            => PrimalType.id(kind);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Indicator(this NumericKind k)
            => PrimalType.indicator(k);

        /// <summary>
        /// Determines whether a specified kind is included within a classification
        /// </summary>
        /// <param name="k">The classification</param>
        /// <param name="match">The kind to check</param>
        [MethodImpl(Inline)]
        public static bit Is(this NumericKind k, NumericKind match)        
            => (k & match) != 0;

        [MethodImpl(Inline)]
        public static bit Is(this NumericKind k, PrimalId match)        
            => ((uint)k & (uint)match) != 0;

        public static IEnumerable<NumericKind> DistinctKinds(this NumericKind k)       
        {
            if(k.Is(PrimalId.U8))
                yield return NumericKind.U8;

            if(k.Is(PrimalId.I8))
                yield return NumericKind.I8;

            if(k.Is(PrimalId.U16))
                yield return NumericKind.U16;

            if(k.Is(PrimalId.I16))
                yield return NumericKind.I16;

            if(k.Is(PrimalId.U32))
                yield return NumericKind.U32;

            if(k.Is(PrimalId.I32))
                yield return NumericKind.I32;

            if(k.Is(PrimalId.U64))
                yield return NumericKind.U64;

            if(k.Is(PrimalId.I64))
                yield return NumericKind.I64;

            if(k.Is(PrimalId.F32))
                yield return NumericKind.F32;

            if(k.Is(PrimalId.F64))
                yield return NumericKind.F64;
        }



        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static IEnumerable<Type> PrimalTypes(this NumericKind k)
            => k.DistinctKinds().Select(x => x.ToPrimalType());         

        /// <summary>
        /// Determines the primal kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericKind Kind(this Type t)
            => PrimalType.kind(t);
         
        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNatSpan(this Type t)
            => NatSpanType.signature(t).IsSome();

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(this Type t, bool includeReadOnly = true)
            => (t.GenericDefinition() == typeof(Span<>))
            ||(includeReadOnly 
                && t.GenericDefinition() == typeof(ReadOnlySpan<>));

        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this VectorKind k)
            => VectorType.width(k);

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this VectorKind k)
            => k != VectorKind.None;

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this BlockKind k)
            => k != BlockKind.None;

        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBlocked(this Type t)
            => BlockedType.test(t);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => Types.segmented(t);

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth Width(this Type t)
            => Types.width(t);

        public static string TypeKeyword(this Type src)
            => DataTypes.keyword(src).ValueOrDefault(string.Empty);

        /// <summary>
        /// Retrives the primal kind of the first type parameter, if any
        /// </summary>
        /// <param name="method">The method to test</param>
        /// <param name="n">The generic parameter selector</param>
        [MethodImpl(Inline)]
        public static NumericKind TypeParameterKind(this MethodInfo method, N1 n)
            => (method.IsGenericMethod ? method.GetGenericArguments() : array<Type>()).FirstOrDefault()?.Kind() ?? NumericKind.None;

        [MethodImpl(Inline)]
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF 
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;        
    }
}