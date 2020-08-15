//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R16<R> : IRegOperand16<R16<R>,R>
        where R : unmanaged, IRegOperand16
    {
        public readonly ushort Data;

        [MethodImpl(Inline)]
        public R16(ushort value)
            => Data = value;

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        ushort IOperand<ushort>.Content 
            => Data;
    }
}