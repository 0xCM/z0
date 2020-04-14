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


        public readonly struct Add<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Sub<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Mul<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Div<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

        public readonly struct Mod<T> : IArithmeticKind<Mod,T> where T : unmanaged {}

    }
}