//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class OpTypes
    {
        public readonly struct Negate : IKnownOpType<Negate> {}

        public readonly struct And : IKnownOpType<And> {}

        public readonly struct Or : IKnownOpType<Or> {}

        public readonly struct Xor : IKnownOpType<Xor> {}

        public readonly struct Nand : IKnownOpType<Nand> {}

        public readonly struct Nor : IKnownOpType<Nor> {}

        public readonly struct Xnor : IKnownOpType<Xnor> {}

        public readonly struct Impl : IKnownOpType<Impl> {}

        public readonly struct NonImpl : IKnownOpType<NonImpl> {}

        public readonly struct CImpl : IKnownOpType<CImpl> {}

        public readonly struct CNonImpl : IKnownOpType<CNonImpl> {}

        public readonly struct Not : IKnownOpType<Not> {}
         
    }
}