//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = BooleanPredicateKind;
    using I = IBooleanPredicateKind;

    partial class Kinds
    {
        public readonly struct Odd : I { public K Kind { [MethodImpl(Inline)] get => K.Odd;} }

        public readonly struct Even : I { public K Kind { [MethodImpl(Inline)] get => K.Even;} }
    }
}