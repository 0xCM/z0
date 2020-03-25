//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = ArityClass;

    partial class OpClass
    {
        public readonly struct Unary : ILiteralKind<C> { public C Class => C.Unary; }

        public readonly struct Binary : ILiteralKind<C> { public C Class => C.Binary; }

        public readonly struct Ternary : ILiteralKind<C> { public C Class => C.Ternary; }

        public readonly struct Unary<T> : ILiteralKind<C,T> where T : unmanaged { public C Class => C.Unary; }

        public readonly struct Binary<T> : ILiteralKind<C,T>  where T : unmanaged { public C Class => C.Binary; }

        public readonly struct Ternary<T> : ILiteralKind<C,T>  where T : unmanaged { public C Class => C.Ternary; }
    }
}