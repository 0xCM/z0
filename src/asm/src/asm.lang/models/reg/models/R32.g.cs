//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct R32<R> : IRegister<R32<R>,W32,uint>, IRegOp32<uint>
        where R : unmanaged, IRegOp32
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public R32(uint value)
            => Content = value;

        public RegisterKind RegKind
        {
            [MethodImpl(Inline)]
            get => default(R).RegKind;
        }

        [MethodImpl(Inline)]
        public static implicit operator R32(R32<R> src)
            => new R32(src.Content, src.RegKind);
    }
}