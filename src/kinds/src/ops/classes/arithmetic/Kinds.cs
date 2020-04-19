//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = ArithmeticKind;
    using I = IArithmeticKind;

    partial class Kinds
    {
        public readonly struct Add : I { public K Kind { [MethodImpl(Inline)] get => K.Add;}}

        public readonly struct Sub : I { public K Kind { [MethodImpl(Inline)] get => K.Sub;}}

        public readonly struct Mul : I { public K Kind { [MethodImpl(Inline)] get => K.Mul;}}

        public readonly struct Div : I { public K Kind { [MethodImpl(Inline)] get => K.Div;}}

        public readonly struct Mod : I { public K Kind { [MethodImpl(Inline)] get => K.Mod;}}

        public readonly struct Clamp : I { public K Kind { [MethodImpl(Inline)] get => K.Clamp;}}

        public readonly struct Dot : I { public K Kind { [MethodImpl(Inline)] get => K.Dot;}}

        public readonly struct Inc : I { public K Kind { [MethodImpl(Inline)] get => K.Inc;}}

        public readonly struct Dec : I { public K Kind { [MethodImpl(Inline)] get => K.Dec;}}

        public readonly struct Negate : I { public K Kind { [MethodImpl(Inline)] get => K.Negate;}}

        public readonly struct Abs : I { public K Kind { [MethodImpl(Inline)] get => K.Abs;}}

        public readonly struct Square : I { public K Kind { [MethodImpl(Inline)] get => K.Square;}}

        public readonly struct Sqrt : I { public K Kind { [MethodImpl(Inline)] get => K.Sqrt;}}
    }
}