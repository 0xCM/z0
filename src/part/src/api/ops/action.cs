//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Api
    {
        [KindFactory]
        public static UnaryActionClass action(A1 rep)
            => default;

        [KindFactory]
        public static BinaryActionClass action(A2 rep)
            => default;

        [KindFactory]
        public static TernaryActionClass action(A3 rep)
            => default;
    }
}