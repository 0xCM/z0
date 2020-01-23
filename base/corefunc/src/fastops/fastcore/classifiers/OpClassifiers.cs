//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class Classifiers
    {
        public readonly struct Add : IOpClass<Add> {}

        public readonly struct Sub : IOpClass<Sub> {}        

        public readonly struct Mul : IOpClass<Mul> {}        

        public readonly struct Div : IOpClass<Div> {}        

        public readonly struct Negate : IOpClass<Negate> {}

        public readonly struct And : IOpClass<And> {}

        public readonly struct Or : IOpClass<Or> {}

        public readonly struct Xor : IOpClass<Xor> {}

        public readonly struct Nand : IOpClass<Nand> {}

        public readonly struct Nor : IOpClass<Nor> {}

        public readonly struct Xnor : IOpClass<Xnor> {}

        public readonly struct Impl : IOpClass<Impl> {}

        public readonly struct NonImpl : IOpClass<NonImpl> {}

        public readonly struct CImpl : IOpClass<CImpl> {}

        public readonly struct CNonImpl : IOpClass<CNonImpl> {}

        public readonly struct Not : IOpClass<Not> {}


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