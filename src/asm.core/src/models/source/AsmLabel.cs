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
        public TextBlock Name {get;}

        [MethodImpl(Inline)]
        public AsmLabel(TextBlock name)
        {
            Name = name;
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