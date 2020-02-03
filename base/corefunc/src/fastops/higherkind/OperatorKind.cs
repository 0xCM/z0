//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class HK
    {
        public readonly struct Add : IOperatorKind<Add> {}

        public readonly struct Sub : IOperatorKind<Sub> {}        

        public readonly struct Mul : IOperatorKind<Mul> {}        

        public readonly struct Div : IOperatorKind<Div> {}        

        public readonly struct Negate : IOperatorKind<Negate> {}

        public readonly struct And : IOperatorKind<And> {}

        public readonly struct Or : IOperatorKind<Or> {}

        public readonly struct Xor : IOperatorKind<Xor> {}

        public readonly struct Nand : IOperatorKind<Nand> {}

        public readonly struct Nor : IOperatorKind<Nor> {}

        public readonly struct Xnor : IOperatorKind<Xnor> {}

        public readonly struct Impl : IOperatorKind<Impl> {}

        public readonly struct NonImpl : IOperatorKind<NonImpl> {}

        public readonly struct CImpl : IOperatorKind<CImpl> {}

        public readonly struct CNonImpl : IOperatorKind<CNonImpl> {}

        public readonly struct Not : IOperatorKind<Not> {}
    }
}