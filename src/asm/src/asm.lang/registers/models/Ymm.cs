//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Ymm : IYmmReg, IRegOp<Cell256>
    {
        public Cell256 Content {get;}

        public RegisterKind RegKind {get;}

        [MethodImpl(Inline)]
        public Ymm(Cell256 value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator Cell256(Ymm src)
            => src.Content;
    }
}