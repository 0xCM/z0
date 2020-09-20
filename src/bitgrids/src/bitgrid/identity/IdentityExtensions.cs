// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static ApiGridKind;

    public static class BitGridIdentityX
    {
        [MethodImpl(Inline)]
        public static bool IsPrimalGeneric(this ApiGridKind k)
            => (k & NumericGeneric) != 0;

        [MethodImpl(Inline)]
        public static bool IsFixedNatural(this ApiGridKind k)
            => (k & FixedNatural) != 0;

        [MethodImpl(Inline)]
        public static bool IsSubGrid(this ApiGridKind k)
            => (k & FixedSubgrid) != 0;

        [MethodImpl(Inline)]
        public static CellWidth Width(this ApiGridKind k)
            => (CellWidth)((ushort)k);

        [MethodImpl(Inline)]
        public static ApiGridClass Category(this ApiGridKind k)
            => (ApiGridClass)(((uint)k >> 16) << 16);

        [MethodImpl(Inline)]
        public static bool IsSome(this ApiGridKind k)
            => k != Z0.ApiGridKind.None;

        public static string Indicator(this ApiGridKind k)
            => k.IsPrimalGeneric() ? GridIndicators.PrimalGeneric
             : k.IsSubGrid() ? GridIndicators.FixedSubgrid
             : k.IsFixedNatural() ? GridIndicators.FixedNatural
             : (k & Z0.ApiGridKind.Generic) != 0 ? GridIndicators.Generic
             : (k & Z0.ApiGridKind.GenericUnfixed) != 0 ? GridIndicators.Generic
             : (k & Z0.ApiGridKind.Natural) != 0 ? GridIndicators.Natural
             : (k & Z0.ApiGridKind.NaturalUnfixed) != 0 ? GridIndicators.Natural
             :  k.ToString();

        public static NatKind GridClosures(this Type src )
        {
            var args = src.GridKind().MapValueOrDefault(k => src.SuppliedTypeArgs().ToArray(), array<Type>());
            if(args.Length == 1)
                return (0, 0, args[0].NumericKind());
            else if(args.Length == 3)
                return (args[0].TypeNatural().NatValue, args[1].TypeNatural().NatValue, args[2].NumericKind());
            else
                return (0, 0, NumericKind.None);
        }

        [MethodImpl(Inline)]
        public static bool IsSome(this NatKind src)
            => !src.IsEmpty;

        [MethodImpl(Inline)]
        public static int NonEmptyCount(this NatKind src)
            => (src.M != 0 ? 1 : 0) + (src.N != 0 ? 1 : 0)  + (src.T.IsSome() ? 1 : 0);

        public static Option<ApiGridKind> GridKind(this Type src)
        {
            var def =  src.GenericDefinition().ValueOrDefault();
            if(def == null)
                return none<ApiGridKind>();

            if(def == typeof(BitGrid<>))
                return Z0.ApiGridKind.NumericGeneric;
            else if(def == typeof(BitGrid<,,>))
                return Z0.ApiGridKind.NaturalUnfixed;
            if(def == typeof(BitGrid16<>))
                return Z0.ApiGridKind.Numeric16;
            else if(def == typeof(BitGrid32<>))
                return Z0.ApiGridKind.Numeric32;
            else if(def == typeof(BitGrid64<>))
                return Z0.ApiGridKind.Numeric64;
            else if(def == typeof(BitGrid16<,,>))
                return Z0.ApiGridKind.Natural16;
            else if(def == typeof(BitGrid32<,,>))
                return Z0.ApiGridKind.Natural32;
            else if(def == typeof(BitGrid64<,,>))
                return Z0.ApiGridKind.Natural64;
            else if(def == typeof(BitGrid128<,,>))
                return Z0.ApiGridKind.Natural128;
            else if(def == typeof(BitGrid256<,,>))
                return Z0.ApiGridKind.Natural256;
            else if(def == typeof(SubGrid16<,,>))
                return Z0.ApiGridKind.Subgrid16;
            else if(def == typeof(SubGrid32<,,>))
                return Z0.ApiGridKind.Subgrid32;
            else if(def == typeof(SubGrid64<,,>))
                return Z0.ApiGridKind.Subgrid64;
            else if(def == typeof(SubGrid128<,,>))
                return Z0.ApiGridKind.Subgrid128;
            else if(def == typeof(SubGrid256<,,>))
                return Z0.ApiGridKind.Subgrid256;
            else
                return none<ApiGridKind>();
        }

        [MethodImpl(Inline)]
        public static Option<CellWidth> GridWidth(this Type src)
            => src.GridKind().TryMap(k => k.Width());
    }
}