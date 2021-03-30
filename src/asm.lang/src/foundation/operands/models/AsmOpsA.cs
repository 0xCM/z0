//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures an operand
    /// </summary>
    public struct AsmOps<A> : IAsmOps<AsmOps<A>,A>
        where A : unmanaged, IAsmOp
    {
        public A _A;

        [MethodImpl(Inline)]
        public AsmOps(A a)
            => _A = a;

        public A this[N0 n]
        {
            [MethodImpl(Inline)]
            get => _A;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmOps<A>(A src)
            => new AsmOps<A>(src);
    }
}