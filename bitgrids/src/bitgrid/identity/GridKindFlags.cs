// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;
    
    [Flags]
    public enum GridKind : uint
    {
        None = 0,

        Generic = GridCategory.Generic,
        
        Natural = GridCategory.Natural,

        Fixed = GridCategory.Fixed,

        Unfixed = GridCategory.Dynamic,

        Subgrid = GridCategory.Subgrid,

        Numeric = GridCategory.Numeric,
        
        GenericUnfixed = GridCategory.GenericDynamic,

        NaturalUnfixed = GridCategory.NaturalDynamic,

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
}