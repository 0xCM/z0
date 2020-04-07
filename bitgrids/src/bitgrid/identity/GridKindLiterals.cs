// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;
    
    public enum DynamicGridKind : uint
    {
        None = 0,

        Generic = GridCategory.GenericDynamic,

        Natural = GridCategory.NaturalDynamic
    }

    public enum FixedNumericGridKind : uint
    {
        None = 0,

        FN16 = 16 | GridCategory.NumericGeneric,

        FN32 = 32 | GridCategory.NumericGeneric,

        FN64 = 64 | GridCategory.NumericGeneric,
    }

    public enum FixedNaturalGridKind : uint
    {
        None = 0,

        FN16 = 16 | GridCategory.FixedNatural,

        FN32 = 32 | GridCategory.FixedNatural,

        FN64 = 64 | GridCategory.FixedNatural,

        FN128 = 128 | GridCategory.FixedNatural,
        
        FN256 = 256 | GridCategory.FixedNatural,
    }

    public enum FixedSubGridKind : uint
    {
        None = 0,

        FSG16 = 16 | GridCategory.FixedSubgrid,

        FSG32 = 32 | GridCategory.FixedSubgrid,

        FSG64 = 64 | GridCategory.FixedSubgrid,

        FSG128 = 128 | GridCategory.FixedSubgrid,
        
        FSG256 = 256 | GridCategory.FixedSubgrid,
    }
}