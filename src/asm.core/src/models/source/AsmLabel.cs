//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmLabel
    {
        public CharBlock32 Name {get;}

        public Hex64 Offset {get;}

        [MethodImpl(Inline)]
        public AsmLabel(in CharBlock32 name, Hex64 offset = default)
        {
            Name = name;
            Offset = offset;
        }

        public AsmLinePart TokenKind
        {
            [MethodImpl(Inline)]
            get => AsmLinePart.Label;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}