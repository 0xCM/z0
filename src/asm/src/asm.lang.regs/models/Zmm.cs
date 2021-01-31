//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Zmm : IZmmReg
    {
        public Cell512 Content {get;}

        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public Zmm(Cell512 value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        public RegClass Class
            => RegClass.ZMM;
    }
}