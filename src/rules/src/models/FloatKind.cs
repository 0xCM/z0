//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules.DataKind;

    using W = DataWidth;

    partial struct Rules
    {
        [System.Flags]
        public enum FloatKind : ushort
        {
            None = 0,

            Float16 = Float | W.W16,

            Float32 = Float | W.W32,

            Float64 = Float | W.W64,

            Float128 = Float | W.W128,

            Float256 = Float | W.W256,

            Float512 = Float | W.W512,
        }

    }
}