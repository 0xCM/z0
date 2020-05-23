//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    partial class Kinds
    {
        public readonly struct Reverse<T> : ICanonicalKind<Reverse,T> {}

        public readonly struct Identity<T> : ICanonicalKind<Identity,T> {}

        public readonly struct Concat<T> : ICanonicalKind<Concat,T> {}

        public readonly struct Parse<T> : ICanonicalKind<Parse,T> {}

        public readonly struct Slice<T> : ICanonicalKind<Slice,T> {}

        public readonly struct Zero<T> : ICanonicalKind<Zero,T> {}

        public readonly struct One<T> : ICanonicalKind<One,T> {}

        public readonly struct Test<T> : ICanonicalKind<Test,T> {}

        public readonly struct Zip<T> : ICanonicalKind<Zip,T> {}

    }
}