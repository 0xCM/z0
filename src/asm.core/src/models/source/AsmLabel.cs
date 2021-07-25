//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmLabel : IAsmLabel
    {
        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public AsmLabel(Identifier name)
            => Name = name;

        public AsmLinePart TokenKind
        {
            [MethodImpl(Inline)]
            get => AsmLinePart.Label;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsNonEmpty;
        }

        public string Format()
            => Name;

        public override string ToString()
            => Format();

        public static AsmLabel Empty
        {
            [MethodImpl(Inline)]
            get => new AsmLabel(Identifier.Empty);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmLabel(string src)
            => new AsmLabel(src);
    }
}