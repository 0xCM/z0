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
    public enum GridKind : uint
    {
        None = 0,

        Generic = GridClass.Generic,

        Natural = GridClass.Natural,

        Fixed = GridClass.Fixed,

        Unfixed = GridClass.Dynamic,

        Subgrid = GridClass.Subgrid,

        Numeric = GridClass.Numeric,

        GenericUnfixed = GridClass.GenericDynamic,

        NaturalUnfixed = GridClass.NaturalDynamic,

        FixedNatural = GridClass.FixedNatural,

        FixedSubgrid = GridClass.FixedSubgrid,

        NumericGeneric = GridClass.NumericGeneric,

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

        Generic = GridClass.GenericDynamic,

        Natural = GridClass.NaturalDynamic
    }

    public enum FixedNumericGridKind : uint
    {
        None = 0,

        FN16 = 16 | GridClass.NumericGeneric,

        FN32 = 32 | GridClass.NumericGeneric,

        FN64 = 64 | GridClass.NumericGeneric,
    }

    public enum FixedNaturalGridKind : uint
    {
        None = 0,

        FN16 = 16 | GridClass.FixedNatural,

        FN32 = 32 | GridClass.FixedNatural,

        FN64 = 64 | GridClass.FixedNatural,

        FN128 = 128 | GridClass.FixedNatural,

        FN256 = 256 | GridClass.FixedNatural,
    }

    public enum FixedSubGridKind : uint
    {
        None = 0,

        FSG16 = 16 | GridClass.FixedSubgrid,

        FSG32 = 32 | GridClass.FixedSubgrid,

        FSG64 = 64 | GridClass.FixedSubgrid,

        FSG128 = 128 | GridClass.FixedSubgrid,

        FSG256 = 256 | GridClass.FixedSubgrid,
    }
}