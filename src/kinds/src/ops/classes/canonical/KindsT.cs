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
        public readonly struct Reverse<T> : ICanonicalKind<Reverse,T> where T : unmanaged { }

        public readonly struct Identity<T> : ICanonicalKind<Identity,T> where T : unmanaged { }

        public readonly struct Concat<T> : ICanonicalKind<Concat,T> where T : unmanaged { }
    }
}