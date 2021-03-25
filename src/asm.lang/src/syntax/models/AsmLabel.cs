//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmLabel : IAsmLabel
    {
        public TextBlock Content {get;}

        public AsmLabelKind Kind {get;}

        [MethodImpl(Inline)]
        public AsmLabel(TextBlock content, AsmLabelKind kind)
        {
            Content = content;
            Kind = kind;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

    }
}