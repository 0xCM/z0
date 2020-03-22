//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = ActionClass;

    public static partial class Classes
    {
        public readonly struct ActionClass : IOpClass<C> { public C Class => C.Action; }

        public readonly struct Receiver : IOpClass<C> { public C Class => C.Receiver; }

        public readonly struct UnaryAction : IOpClass<C> { public C Class => C.UnaryAction; }

        public readonly struct BinaryAction : IOpClass<C> { public C Class => C.BinaryAction; }

        public readonly struct TernaryAction : IOpClass<C> { public C Class => C.TernaryAction; }

        public readonly struct Receiver<T> : IOpClass<C,T> where T : unmanaged { public C Class => C.Receiver; }

        public readonly struct UnaryAction<T> : IOpClass<C,T> where T : unmanaged {public C Class => C.UnaryAction; }

        public readonly struct BinaryAction<T> : IOpClass<C,T> where T : unmanaged {public C Class => C.BinaryAction; }

        public readonly struct TernaryAction<T> : IOpClass<C,T> where T : unmanaged {public C Class => C.TernaryAction; }
    }
}