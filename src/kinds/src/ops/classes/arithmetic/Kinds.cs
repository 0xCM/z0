//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = ArithmeticKind;

    partial class Kinds
    {
        public readonly struct Add : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Add;}}

        public readonly struct Sub : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Sub;}}

        public readonly struct Mul : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Mul;}}

        public readonly struct Div : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Div;}}

        public readonly struct Mod : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Mod;}}

        public readonly struct Clamp : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Clamp;}}

        public readonly struct Dot : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Dot;}}

        public readonly struct Inc : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Inc;}}

        public readonly struct Dec : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Dec;}}

        public readonly struct Negate : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Negate;}}

        public readonly struct Abs : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Abs;}}

        public readonly struct Square : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Square;}}

        public readonly struct Sqrt : IArithmeticKind { public Id Kind { [MethodImpl(Inline)] get => Id.Sqrt;}}

        public readonly struct Add<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Sub<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Mul<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Div<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Mod<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Clamp<T> : IArithmeticKind<Clamp,T> where T : unmanaged {}

        public readonly struct Dot<T> : IArithmeticKind<Dot,T> where T : unmanaged {}

        public readonly struct Inc<T> : IArithmeticKind<Inc,T> where T : unmanaged {}

        public readonly struct Dec<T> : IArithmeticKind<Dec,T> where T : unmanaged {}

        public readonly struct Negate<T> : IArithmeticKind<Negate,T> where T : unmanaged {}

        public readonly struct Abs<T> : IArithmeticKind<Abs,T> where T : unmanaged {}

        public readonly struct Square<T> : IArithmeticKind<Square,T> where T : unmanaged {}

        public readonly struct Sqrt<T> : IArithmeticKind<Sqrt,T> where T : unmanaged {}


    }
}