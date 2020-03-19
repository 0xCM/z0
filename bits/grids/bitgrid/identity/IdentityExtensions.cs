// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static GridKind;

    public static class BitGridIdentityX
    {
        [MethodImpl(Inline)]
        public static bool IsPrimalGeneric(this GridKind k)
            => (k & NumericGeneric) != 0;

        [MethodImpl(Inline)]
        public static bool IsFixedNatural(this GridKind k)
            => (k & FixedNatural) != 0;

        [MethodImpl(Inline)]
        public static bool IsSubGrid(this GridKind k)
            => (k & FixedSubgrid) != 0;

        [MethodImpl(Inline)]
        public static FixedWidth Width(this GridKind k)
            => (FixedWidth)((ushort)k);

        [MethodImpl(Inline)]
        public static GridCategory Category(this GridKind k)
            => (GridCategory)(((uint)k >> 16) << 16);

        [MethodImpl(Inline)]
        public static bool IsSome(this GridKind k)
            => k != Z0.GridKind.None;

        public static string Indicator(this GridKind k)
            => k.IsPrimalGeneric() ? GridIndicators.PrimalGeneric
             : k.IsSubGrid() ? GridIndicators.FixedSubgrid 
             : k.IsFixedNatural() ? GridIndicators.FixedNatural
             : (k & Z0.GridKind.Generic) != 0 ? GridIndicators.Generic
             : (k & Z0.GridKind.GenericUnfixed) != 0 ? GridIndicators.Generic 
             : (k & Z0.GridKind.Natural) != 0 ? GridIndicators.Natural 
             : (k & Z0.GridKind.NaturalUnfixed) != 0 ? GridIndicators.Natural 
             :  k.ToString();
            

        [MethodImpl(Inline)]
        public static bool BitGridClosed(this Type src)
            => src.GridKind().MapValueOrDefault(k => src.OpenTypeParameterCount() == 0);

        [MethodImpl(Inline)]
        public static bool BitGridOpen(this Type src)
            => src.GridKind().MapValueOrDefault(k => src.OpenTypeParameterCount() != 0);
        
        public static Tripled<FixedWidth,FixedWidth,NumericKind> GridClosures(this Type src )
        {
            var args = src.GridKind().MapValueOrDefault(k => src.SuppliedTypeArgs().ToArray(), array<Type>());
            if(args.Length == 1)
                return (FixedWidth.None, FixedWidth.None, args[0].NumericKind());
            else if(args.Length == 3)
                return ((FixedWidth)args[0].NatValue().ValueOrDefault(), (FixedWidth)args[0].NatValue().ValueOrDefault(), args[0].NumericKind());
            else
                return (FixedWidth.None, FixedWidth.None, NumericKind.None);            
        }

        [MethodImpl(Inline)]
        public static bool IsSome(this Tripled<FixedWidth,FixedWidth,NumericKind> src)
            => src.A.IsSome() || src.B.IsSome() || src.C.IsSome();

        [MethodImpl(Inline)]
        public static int NonEmptyCount(this Tripled<FixedWidth,FixedWidth,NumericKind> src)
            => (src.A.IsSome() ? 1 : 0) + (src.B.IsSome() ? 1 : 0)  + (src.C.IsSome() ? 1 : 0);

        public static Option<GridKind> GridKind(this Type src)
        {
            var def =  src.GenericDefinition().ValueOrDefault();
            if(def == null)
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

        [MethodImpl(Inline)]
        public static Option<FixedWidth> GridWidth(this Type src)
            => src.GridKind().TryMap(k => k.Width());
    }
}