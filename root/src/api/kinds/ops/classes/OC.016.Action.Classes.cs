//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = ActionClass;

    public static partial class OpClass
    {
        public readonly struct ActionClass : IOperationClass<C> { public C Class => C.Action; }

        public readonly struct Receiver : IOperationClass<C> { public C Class => C.Receiver; }

        public readonly struct UnaryAction : IOperationClass<C> { public C Class => C.UnaryAction; }

        public readonly struct BinaryAction : IOperationClass<C> { public C Class => C.BinaryAction; }

        public readonly struct TernaryAction : IOperationClass<C> { public C Class => C.TernaryAction; }

        public readonly struct Receiver<T> : IOperationClass<C,T> where T : unmanaged { public C Class => C.Receiver; }

        public readonly struct UnaryAction<T> : IOperationClass<C,T> where T : unmanaged {public C Class => C.UnaryAction; }

        public readonly struct BinaryAction<T> : IOperationClass<C,T> where T : unmanaged {public C Class => C.BinaryAction; }

        public readonly struct TernaryAction<T> : IOperationClass<C,T> where T : unmanaged {public C Class => C.TernaryAction; }
    }
}