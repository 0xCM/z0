//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Kinds
    {
        public readonly struct Add<T> : IArithmeticKind<Add,T> {}

        public readonly struct Sub<T> : IArithmeticKind<Sub,T> {}

        public readonly struct Mul<T> : IArithmeticKind<Mul,T> {}

        public readonly struct Div<T> : IArithmeticKind<Div,T> {}

        public readonly struct Mod<T> : IArithmeticKind<Mod,T> {}

        public readonly struct Clamp<T> : IArithmeticKind<Clamp,T> {}

        public readonly struct Dot<T> : IArithmeticKind<Dot,T> {}

        public readonly struct Inc<T> : IArithmeticKind<Inc,T> {}

        public readonly struct Dec<T> : IArithmeticKind<Dec,T> {}

        public readonly struct Negate<T> : IArithmeticKind<Negate,T> {}

        public readonly struct Abs<T> : IArithmeticKind<Abs,T> {}

        public readonly struct Square<T> : IArithmeticKind<Square,T> {}

        public readonly struct Sqrt<T> : IArithmeticKind<Sqrt,T> {}
    }
}