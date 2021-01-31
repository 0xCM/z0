//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct R8<R> : IRegister<R8<R>,W8,byte>
        where R : unmanaged, IRegister
    {
        public byte Data;

        [MethodImpl(Inline)]
        public R8(byte src)
            => Data = src;

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator R8(R8<R> src)
            => new R8(src.Content, src.Kind);
    }
}