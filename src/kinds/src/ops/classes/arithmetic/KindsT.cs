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