// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static GridKind;

    [ApiHost]
    public static class XGridIdentity
    {
        [MethodImpl(Inline), Op]
        public static bool IsPrimalGeneric(this GridKind k)
            => (k & NumericGeneric) != 0;

        [MethodImpl(Inline), Op]
        public static bool IsFixedNatural(this GridKind k)
            => (k & FixedNatural) != 0;

        [MethodImpl(Inline), Op]
        public static bool IsSubGrid(this GridKind k)
            => (k & FixedSubgrid) != 0;

        [MethodImpl(Inline), Op]
        public static CellWidth Width(this GridKind k)
            => (CellWidth)((ushort)k);

        [MethodImpl(Inline), Op]
        public static GridClass Category(this GridKind k)
            => (GridClass)(((uint)k >> 16) << 16);

        [MethodImpl(Inline), Op]
        public static bool IsSome(this GridKind k)
            => k != Z0.GridKind.None;

        [Op]
        public static string Indicator(this GridKind k)
            => k.IsPrimalGeneric() ? GridIndicators.PrimalGeneric
             : k.IsSubGrid() ? GridIndicators.FixedSubgrid
             : k.IsFixedNatural() ? GridIndicators.FixedNatural
             : (k & Z0.GridKind.Generic) != 0 ? GridIndicators.Generic
             : (k & Z0.GridKind.GenericUnfixed) != 0 ? GridIndicators.Generic
             : (k & Z0.GridKind.Natural) != 0 ? GridIndicators.Natural
             : (k & Z0.GridKind.NaturalUnfixed) != 0 ? GridIndicators.Natural
             :  k.ToString();

        [Op]
        public static NatKind GridClosures(this Type src)
        {
            var args = src.GridKind().MapValueOrDefault(k => src.SuppliedTypeArgs().ToArray(), array<Type>());
            if(args.Length == 1)
                return (0, 0, args[0].NumericKind());
            else if(args.Length == 3)
                return (args[0].TypeNatural().NatValue, args[1].TypeNatural().NatValue, args[2].NumericKind());
            else
                return (0, 0, NumericKind.None);
        }

        [MethodImpl(Inline), Op]
        public static bool IsSome(this NatKind src)
            => !src.IsEmpty;

        [MethodImpl(Inline), Op]
        public static int NonEmptyCount(this NatKind src)
            => (src.M != 0 ? 1 : 0) + (src.N != 0 ? 1 : 0)  + (src.T.IsSome() ? 1 : 0);

        [Op]
        public static Option<GridKind> GridKind(this Type src)
        {
            var def =  src.GenericDefinition2();
            if(def == typeof(void))
                return none<GridKind>();

            if(def == typeof(BitGrid<>))
                return Z0.GridKind.NumericGeneric;
            else if(def == typeof(BitGrid<,,>))
                return Z0.GridKind.NaturalUnfixed;
            if(def == typeof(BitGrid16<>))
                return Z0.GridKind.Numeric16;
            else if(def == typeof(BitGrid32<>))
                return Z0.GridKind.Numeric32;
            else if(def == typeof(BitGrid64<>))
                return Z0.GridKind.Numeric64;
            else if(def == typeof(BitGrid16<,,>))
                return Z0.GridKind.Natural16;
            else if(def == typeof(BitGrid32<,,>))
                return Z0.GridKind.Natural32;
            else if(def == typeof(BitGrid64<,,>))
                return Z0.GridKind.Natural64;
            else if(def == typeof(BitGrid128<,,>))
                return Z0.GridKind.Natural128;
            else if(def == typeof(BitGrid256<,,>))
                return Z0.GridKind.Natural256;
            else if(def == typeof(SubGrid16<,,>))
                return Z0.GridKind.Subgrid16;
            else if(def == typeof(SubGrid32<,,>))
                return Z0.GridKind.Subgrid32;
            else if(def == typeof(SubGrid64<,,>))
                return Z0.GridKind.Subgrid64;
            else if(def == typeof(SubGrid128<,,>))
                return Z0.GridKind.Subgrid128;
            else if(def == typeof(SubGrid256<,,>))
                return Z0.GridKind.Subgrid256;
            else
                return none<GridKind>();
        }

        [MethodImpl(Inline), Op]
        public static Option<CellWidth> GridWidth(this Type src)
            => src.GridKind().TryMap(k => k.Width());
    }
}