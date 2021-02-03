//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static DataWidth;
    using static DataKind;

    [System.Flags]
    public enum FloatKind : ushort
    {
        None = 0,

        Float16 = Float | W16,

        Float32 = Float | W32,

        Float64 = Float | W64,

        Float128 = Float | W128,

        Float256 = Float | W256,

        Float512 = Float | W512,
    }
}