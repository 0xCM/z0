//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Xmm : IXmmReg
    {
        public Cell128 Content {get;}

        public RegisterKind Kind {get;}

        public RegisterIndex Index
        {
            [MethodImpl(Inline)]
            get => Registers.code(Kind);
        }

        [MethodImpl(Inline)]
        public Xmm(Cell128 value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        public RegisterClass Class
            => RegisterClass.XMM;
    }
}