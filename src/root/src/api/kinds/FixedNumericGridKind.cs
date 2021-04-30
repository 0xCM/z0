// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum FixedNumericGridKind : uint
    {
        None = 0,

        FN16 = 16 | ApiGridCategory.NumericGeneric,

        FN32 = 32 | ApiGridCategory.NumericGeneric,

        FN64 = 64 | ApiGridCategory.NumericGeneric,
    }
}