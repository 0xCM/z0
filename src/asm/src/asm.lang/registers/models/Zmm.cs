//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Zmm : IZmmReg, IRegOp<Cell512>
    {
        public Cell512 Content {get;}

        public RegisterKind RegKind {get;}

        [MethodImpl(Inline)]
        public Zmm(Cell512 value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

    }
}