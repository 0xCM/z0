// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static GridKind;

    readonly struct BitGridIdentity : ITypeIdentityProvider
    {        
        public TypeIdentity DefineIdentity(Type src)
        {
            var kind = src.GridKind().ValueOrDefault();
            if(!kind.IsSome())
                return TypeIdentity.Empty;
            if(src.IsOpenGeneric())
                return TypeIdentity.Define(kind.Indicator());
            
            var closures = src.GridClosures();
            if(!closures.IsSome())
                return TypeIdentity.Empty;
            
            var segsep = IDI.SegSep.ToString();
            var count = closures.NonEmptyCount();

            if(count == 1)
                return TypeIdentity.Define(concat(kind.Indicator(), closures.C.Format()));
            else if(count == 3)
                return TypeIdentity.Define(concat(
                        kind.Indicator(), segsep, 
                        kind.Width().Format(), segsep, 
                        closures.A.Format(), segsep,
                        closures.B.Format(), segsep,
                        closures.C.Format()
                        ));
            else 
                return TypeIdentity.Empty;            
        }
    }

    [Flags]
    public enum GridCategory : uint
    {
        None = 0,

        Generic = Pow2.T16,
        
        Natural = Pow2.T17,

        Fixed = Pow2.T18,

        Unfixed = Pow2.T19,

        Subgrid = Pow2.T20,

        Numeric = Pow2.T21,
        
        GenericUnfixed = Generic | Unfixed,

        NaturalUnfixed = Natural | Unfixed,

        FixedNatural = Fixed | Natural,

        FixedSubgrid = FixedNatural | Subgrid,

        NumericGeneric = Fixed | Numeric | Generic,        
    }

    [Flags]
    public enum GridKind : uint
    {
        None = 0,

        Generic = GridCategory.Generic,
        
        Natural = GridCategory.Natural,

        Fixed = GridCategory.Fixed,

        Unfixed = GridCategory.Unfixed,

        Subgrid = GridCategory.Subgrid,

        Numeric = GridCategory.Numeric,
        
        GenericUnfixed = GridCategory.GenericUnfixed,

        NaturalUnfixed = GridCategory.NaturalUnfixed,

        FixedNatural = GridCategory.FixedNatural,

        FixedSubgrid = GridCategory.FixedSubgrid,

        NumericGeneric = GridCategory.NumericGeneric,
        
        Numeric16 = 16 | NumericGeneric,

        Numeric32 = 32 | NumericGeneric,

        Numeric64 = 64 | NumericGeneric,

        Natural16 = 16 | FixedNatural,

        Natural32 = 32 | FixedNatural,

        Natural64 = 64 | FixedNatural,

        Natural128 = 128 | FixedNatural,

        Natural256 = 256 | FixedNatural,

        Subgrid16 = 16 | FixedSubgrid,

        Subgrid32 = 32 | FixedSubgrid,

        Subgrid64 = 64 | FixedSubgrid,

        Subgrid128 = 128 | FixedSubgrid,

        Subgrid256 = 256 | FixedSubgrid,
    }

    public class GridIndicators
    {   
        public const string Natural = "bgnu";

        public const string Generic = "bgu";

        public const string PrimalGeneric = "bg";

        public const string FixedNatural = "bgn";

        public const string FixedSubgrid = "bgs";
    }

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
        
        public static Triple<FixedWidth,FixedWidth,NumericKind> GridClosures(this Type src )
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
        public static bool IsSome(this Triple<FixedWidth,FixedWidth,NumericKind> src)
            => src.A.IsSome() || src.B.IsSome() || src.C.IsSome();

        [MethodImpl(Inline)]
        public static int NonEmptyCount(this Triple<FixedWidth,FixedWidth,NumericKind> src)
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