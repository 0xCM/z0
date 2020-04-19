//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using K = CanonicalKind;
    using I = ICanonicalKind;

    partial class Kinds
    {
        public readonly struct Reverse : I { public K Kind { [MethodImpl(Inline)] get => K.Reverse;}}

        public readonly struct Identity : I { public K Kind { [MethodImpl(Inline)] get => K.Identity;}}

        public readonly struct Concat : I { public K Kind { [MethodImpl(Inline)] get => K.Concat;}}
    }
}