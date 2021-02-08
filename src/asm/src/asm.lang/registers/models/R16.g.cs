//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct R16<R> : IRegister<R16<R>,W16,ushort>, IRegOp<ushort>
        where R : unmanaged, IRegister
    {
        public ushort Content {get;}

        [MethodImpl(Inline)]
        public R16(ushort value)
            => Content = value;

        public RegisterKind RegKind
        {
            [MethodImpl(Inline)]
            get => default(R).RegKind;
        }

        [MethodImpl(Inline)]
        public static implicit operator R16(R16<R> src)
            => new R16(src.Content, src.RegKind);
    }
}