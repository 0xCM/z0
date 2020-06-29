//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct r32<R> : IRegOp32<r32<R>,R>
        where R : unmanaged, IRegOp32
    {
        public readonly uint Data;

        [MethodImpl(Inline)]
        public r32(uint value)
            => Data = value;

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        uint IOperand<uint>.Content 
            => Data;
    }
}