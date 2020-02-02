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
    using static BitGridKind;

    readonly struct BitGridIdentity : ITypeIdentityProvider
    {        
        public Option<Moniker> DefineIdentity(Type src)
        {
            var kind = src.GridKind().ValueOrDefault();
            if(!kind.IsSome())
                return none<Moniker>();
            if(src.IsOpenGeneric())
                return Moniker.Parse(kind.Indicator());
            
            var closures = src.GridClosures();
            if(!closures.IsSome())
                return none<Moniker>();
            
            var segsep = Moniker.SegSep.ToString();
            var count = closures.NonEmptyCount();

            if(count == 1)
                return Moniker.Parse(concat(kind.Indicator(), closures.C.Format()));
            else if(count == 3)
                return Moniker.Parse(concat(
                        kind.Indicator(), segsep, 
                        kind.Width().Format(), segsep, 
                        closures.A.Format(), segsep,
                        closures.B.Format(), segsep,
                        closures.C.Format()
                        ));
            else 
                return none<Moniker>();
            
        }
    }

    [Flags]
    public enum BitGridCategory : uint
    {
        None = 0,

        Generic = Pow2.T16,
        
        Natural = Pow2.T17,

        Fixed = Pow2.T18,

        Unfixed = Pow2.T19,

        Subgrid = Pow2.T20,

        Primal = Pow2.T21,
        
        GenericUnfixed = Generic | Unfixed,

        NaturalUnfixed = Natural | Unfixed,

        FixedNatural = Fixed | Natural,

        FixedSubgrid = FixedNatural | Subgrid,

        PrimalGeneric = Fixed | Primal | Generic,        
    }

    [Flags]
    public enum BitGridKind : uint
    {
        None = 0,

        Generic = BitGridCategory.Generic,
        
        Natural = BitGridCategory.Natural,

        Fixed = BitGridCategory.Fixed,

        Unfixed = BitGridCategory.Unfixed,

        Subgrid = BitGridCategory.Subgrid,

        Primal = BitGridCategory.Primal,
        
        GenericUnfixed = BitGridCategory.GenericUnfixed,

        NaturalUnfixed = BitGridCategory.NaturalUnfixed,

        FixedNatural = BitGridCategory.FixedNatural,

        FixedSubgrid = BitGridCategory.FixedSubgrid,

        PrimalGeneric = BitGridCategory.PrimalGeneric,
        
        Primal16 = 16 | PrimalGeneric,

        Primal32 = 32 | PrimalGeneric,

        Primal64 = 64 | PrimalGeneric,

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


    public class BitGridIndicators
    {   
        public const string Generic = "bgg";

        public const string Natural = "bgn";

        public const string PrimalGeneric = "bgpg";

        public const string FixedNatural = "bgfn";

        public const string FixedSubgrid = "bgsg";
    }

    public static class BitGridIdentityX
    {
        [MethodImpl(Inline)]
        public static bool IsPrimalGeneric(this BitGridKind k)
            => (k & PrimalGeneric) != 0;

        [MethodImpl(Inline)]
        public static bool IsFixedNatural(this BitGridKind k)
            => (k & FixedNatural) != 0;

        [MethodImpl(Inline)]
        public static bool IsSubGrid(this BitGridKind k)
            => (k & FixedSubgrid) != 0;

        [MethodImpl(Inline)]
        public static FixedWidth Width(this BitGridKind k)
            => (FixedWidth)((ushort)k);

        [MethodImpl(Inline)]
        public static BitGridCategory Category(this BitGridKind k)
            => (BitGridCategory)(((uint)k >> 16) << 16);


        [MethodImpl(Inline)]
        public static bool IsSome(this BitGridKind k)
            => k != BitGridKind.None;

        public static string Indicator(this BitGridKind k)
            => k.IsPrimalGeneric() ? BitGridIndicators.PrimalGeneric
             : k.IsSubGrid() ? BitGridIndicators.FixedSubgrid 
             : k.IsFixedNatural() ? BitGridIndicators.FixedNatural
             : (k & BitGridKind.Generic) != 0 ? BitGridIndicators.Generic
             : (k & BitGridKind.GenericUnfixed) != 0 ? BitGridIndicators.Generic 
             : (k & BitGridKind.Natural) != 0 ? BitGridIndicators.Natural 
             : (k & BitGridKind.NaturalUnfixed) != 0 ? BitGridIndicators.Natural 
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

        public static Option<BitGridKind> GridKind(this Type src)
        {
            var def =  src.GenericDefinition().ValueOrDefault();
            if(def == null)
                return none<BitGridKind>();

            if(def == typeof(BitGrid<>))
                return BitGridKind.PrimalGeneric;
            else if(def == typeof(BitGrid<,,>))
                return BitGridKind.NaturalUnfixed;
            if(def == typeof(BitGrid16<>))
                return BitGridKind.Primal16;
            else if(def == typeof(BitGrid32<>))
                return BitGridKind.Primal32;
            else if(def == typeof(BitGrid64<>))
                return BitGridKind.Primal64;
            else if(def == typeof(BitGrid16<,,>))
                return BitGridKind.Natural16;
            else if(def == typeof(BitGrid32<,,>))
                return BitGridKind.Natural32;
            else if(def == typeof(BitGrid64<,,>))
                return BitGridKind.Natural64;
            else if(def == typeof(BitGrid128<,,>))
                return BitGridKind.Natural128;
            else if(def == typeof(BitGrid256<,,>))
                return BitGridKind.Natural256;
            else if(def == typeof(SubGrid16<,,>))
                return BitGridKind.Subgrid16;
            else if(def == typeof(SubGrid32<,,>))
                return BitGridKind.Subgrid32;
            else if(def == typeof(SubGrid64<,,>))
                return BitGridKind.Subgrid64;
            else if(def == typeof(SubGrid128<,,>))
                return BitGridKind.Subgrid128;
            else if(def == typeof(SubGrid256<,,>))
                return BitGridKind.Subgrid256;
            else
                return none<BitGridKind>();
        }

        [MethodImpl(Inline)]
        public static Option<FixedWidth> GridWidth(this Type src)
            => src.GridKind().TryMap(k => k.Width());

    }
}