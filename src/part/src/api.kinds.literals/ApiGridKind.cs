// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines grid-sort datatype classifiers
    /// </summary>
    [Flags]
    public enum ApiGridKind : uint
    {
        None = 0,

        Generic = ApiGridClass.Generic,

        Natural = ApiGridClass.Natural,

        Fixed = ApiGridClass.Fixed,

        Unfixed = ApiGridClass.Dynamic,

        Subgrid = ApiGridClass.Subgrid,

        Numeric = ApiGridClass.Numeric,

        GenericUnfixed = ApiGridClass.GenericDynamic,

        NaturalUnfixed = ApiGridClass.NaturalDynamic,

        FixedNatural = ApiGridClass.FixedNatural,

        FixedSubgrid = ApiGridClass.FixedSubgrid,

        NumericGeneric = ApiGridClass.NumericGeneric,

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


    public enum DynamicGridKind : uint
    {
        None = 0,

        Generic = ApiGridClass.GenericDynamic,

        Natural = ApiGridClass.NaturalDynamic
    }

    public enum FixedNumericGridKind : uint
    {
        None = 0,

        FN16 = 16 | ApiGridClass.NumericGeneric,

        FN32 = 32 | ApiGridClass.NumericGeneric,

        FN64 = 64 | ApiGridClass.NumericGeneric,
    }

    public enum FixedNaturalGridKind : uint
    {
        None = 0,

        FN16 = 16 | ApiGridClass.FixedNatural,

        FN32 = 32 | ApiGridClass.FixedNatural,

        FN64 = 64 | ApiGridClass.FixedNatural,

        FN128 = 128 | ApiGridClass.FixedNatural,

        FN256 = 256 | ApiGridClass.FixedNatural,
    }

    public enum FixedSubGridKind : uint
    {
        None = 0,

        FSG16 = 16 | ApiGridClass.FixedSubgrid,

        FSG32 = 32 | ApiGridClass.FixedSubgrid,

        FSG64 = 64 | ApiGridClass.FixedSubgrid,

        FSG128 = 128 | ApiGridClass.FixedSubgrid,

        FSG256 = 256 | ApiGridClass.FixedSubgrid,
    }
}