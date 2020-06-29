//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct r16<R> : IRegOp16<r16<R>,R>
        where R : unmanaged, IRegOp16
    {
        public readonly ushort Data;

        [MethodImpl(Inline)]
        public r16(ushort value)
        {
            Data = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        ushort IOperand<ushort>.Content 
            => Data;
    }
}