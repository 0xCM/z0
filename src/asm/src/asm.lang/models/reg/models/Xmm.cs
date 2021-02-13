//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Xmm : IXmmReg, IRegOp128<Cell128>
    {
        public Cell128 Content {get;}

        public RegisterKind RegKind {get;}

        public RegIndex Index
        {
            [MethodImpl(Inline)]
            get => Registers.code(RegKind);
        }

        [MethodImpl(Inline)]
        public Xmm(Cell128 value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator Cell128(Xmm src)
            => src.Content;
    }
}