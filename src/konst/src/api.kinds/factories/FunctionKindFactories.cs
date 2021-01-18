//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = Kinds;

    partial class Kinds
    {
        [KindFactory]
        public static K.EmitterFunc func(N0 n)
            => default;

        [KindFactory]
        public static K.UnaryFunc func(N1 n)
            => default;

        [KindFactory]
        public static K.BinaryFunc func(N2 n)
            => default;

        [KindFactory]
        public static K.TernaryFunc func(N3 rep)
            => default;

    }
}