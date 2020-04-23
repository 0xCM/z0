//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = ComparisonKind;
    using I = IComparisonKind;

    partial class Kinds
    {
        public readonly struct Lt : I { public K Kind { [MethodImpl(Inline)] get => K.Lt;}}

        public readonly struct LtEq : I { public K Kind { [MethodImpl(Inline)] get => K.LtEq;}}

        public readonly struct Gt : I { public K Kind { [MethodImpl(Inline)] get => K.Gt;}}

        public readonly struct GtEq : I { public K Kind { [MethodImpl(Inline)] get => K.GtEq;}}

        public readonly struct Eq : I { public K Kind { [MethodImpl(Inline)] get => K.Eq;}}

        public readonly struct Neq : I { public K Kind { [MethodImpl(Inline)] get => K.Neq;}}

    }
}