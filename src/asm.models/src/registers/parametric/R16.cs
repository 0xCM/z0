//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R16<R> : IRegister<R16<R>,W16,ushort>
        where R : unmanaged, IRegister
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

        ushort IAsmArg<ushort>.Content
            => Data;
    }
}