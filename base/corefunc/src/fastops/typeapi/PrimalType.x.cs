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
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    partial class TypeApiX
    {
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Type ToPrimalType(this PrimalKind k)
            => PrimalType.fromkind(k);

        [MethodImpl(Inline)]
        public static bool IsSigned(this PrimalKind k)
            => (k & PrimalKind.Signed) != 0;

        [MethodImpl(Inline)]
        public static bool IsUnsigned(this PrimalKind k)
            => (k & PrimalKind.Unsigned) != 0;

        [MethodImpl(Inline)]
        public static bool IsFractional(this PrimalKind k)
            => (k & PrimalKind.Fractional) != 0;

        [MethodImpl(Inline)]
        public static bool IsSome(this PrimalKind k)
            => k != PrimalKind.None;

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static string Keyword(this PrimalKind k)
            => PrimalType.keyword(k);

        /// <summary>
        /// Returns the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static string TypeKeyword(this PrimalKind k)
            => PrimalType.keyword(k);

        /// <summary>
        /// Specifies the bit-width of a classified primitive
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this PrimalKind k)
            => PrimalType.width(k);

        /// <summary>
        /// Determines the kind identifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]
        public static PrimalId Id(this PrimalKind kind)
            => PrimalType.id(kind);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Indicator(this PrimalKind k)
            => PrimalType.indicator(k);

        /// <summary>
        /// Determines whether a specified kind is included within a classification
        /// </summary>
        /// <param name="k">The classification</param>
        /// <param name="match">The kind to check</param>
        [MethodImpl(Inline)]
        public static bit Is(this PrimalKind k, PrimalKind match)        
            => (k & match) != 0;

        /// <summary>
        /// Selects the distinct primal kinds represented by a classifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        public static IEnumerable<PrimalKind> DistinctKinds(this PrimalKind k)       
        {
            if(k.Is(PrimalKind.U8))
                yield return PrimalKind.U8;

            if(k.Is(PrimalKind.I8))
                yield return PrimalKind.I8;

            if(k.Is(PrimalKind.U16))
                yield return PrimalKind.U16;

            if(k.Is(PrimalKind.I16))
                yield return PrimalKind.I16;

            if(k.Is(PrimalKind.U32))
                yield return PrimalKind.U32;

            if(k.Is(PrimalKind.I32))
                yield return PrimalKind.I32;

            if(k.Is(PrimalKind.U64))
                yield return PrimalKind.U64;

            if(k.Is(PrimalKind.I64))
                yield return PrimalKind.I64;

            if(k.Is(PrimalKind.F32))
                yield return PrimalKind.F32;

            if(k.Is(PrimalKind.F64))
                yield return PrimalKind.F64;
        }

        public static PrimalKind ToKind(this PrimalId id)
            => PrimalType.kind(id);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static IEnumerable<Type> PrimalTypes(this PrimalKind k)
            => k.DistinctKinds().Select(x => x.ToPrimalType());         

        /// <summary>
        /// Computes the primal identifies of the classified kinds
        /// </summary>
        /// <param name="k"></param>
        public static IEnumerable<PrimalId> Identities(this PrimalKind k)       
        {
            if(k.Is(PrimalKind.U8))
                yield return PrimalId.U8;

            if(k.Is(PrimalKind.I8))
                yield return PrimalId.I8;

            if(k.Is(PrimalKind.U16))
                yield return PrimalId.U16;

            if(k.Is(PrimalKind.I16))
                yield return PrimalId.I16;

            if(k.Is(PrimalKind.U32))
                yield return PrimalId.U32;

            if(k.Is(PrimalKind.I32))
                yield return PrimalId.I32;

            if(k.Is(PrimalKind.U64))
                yield return PrimalId.U64;

            if(k.Is(PrimalKind.I64))
                yield return PrimalId.I64;

            if(k.Is(PrimalKind.F32))
                yield return PrimalId.F32;

            if(k.Is(PrimalKind.F64))
                yield return PrimalId.F64;
        }

        /// <summary>
        /// Determines the primal kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static PrimalKind Kind(this Type t)
            => PrimalType.kind(t);

        [MethodImpl(Inline)]
        public static bool IsPrimal(this Type t)
            => PrimalType.kind(t) != PrimalKind.None;
    }
}