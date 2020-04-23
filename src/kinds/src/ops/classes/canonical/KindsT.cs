//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Kinds
    {
        public readonly struct Reverse<T> : ICanonicalKind<Reverse,T> {}

        public readonly struct Identity<T> : ICanonicalKind<Identity,T> {}

        public readonly struct Concat<T> : ICanonicalKind<Concat,T> {}

        public readonly struct Parse<T> : ICanonicalKind<Parse,T> {}
    }
}