//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class OpKinds
    {        
        public readonly struct Add : IOpKind<Add> {}

        public readonly struct Sub : IOpKind<Sub> {}        

        public readonly struct Mul : IOpKind<Mul> {}        

        public readonly struct Div : IOpKind<Div> {}        

        public readonly struct Negate : IOpKind<Negate> {}

        public readonly struct And : IOpKind<And> {}

        public readonly struct Or : IOpKind<Or> {}

        public readonly struct Xor : IOpKind<Xor> {}

        public readonly struct Nand : IOpKind<Nand> {}

        public readonly struct Nor : IOpKind<Nor> {}

        public readonly struct Xnor : IOpKind<Xnor> {}

        public readonly struct Impl : IOpKind<Impl> {}

        public readonly struct NonImpl : IOpKind<NonImpl> {}

        public readonly struct CImpl : IOpKind<CImpl> {}

        public readonly struct CNonImpl : IOpKind<CNonImpl> {}

        public readonly struct Not : IOpKind<Not> {}


        public static And fAnd
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Or fOr
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static Xor fXor
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}