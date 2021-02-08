//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct R64<R> : IRegister<R64<R>,W64,ulong>, IRegOp<ulong>
        where R : unmanaged, IRegister
    {
        public ulong Content {get;}

        [MethodImpl(Inline)]
        public R64(ulong src)
            => Content= src;

        public RegisterKind RegKind
        {
            [MethodImpl(Inline)]
            get => default(R).RegKind;
        }

        [MethodImpl(Inline)]
        public static implicit operator R64(R64<R> src)
            => new R64(src.Content, src.RegKind);
    }
}