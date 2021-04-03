//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmComment
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmComment(TextBlock text)
            => Content = text;

        [MethodImpl(Inline)]
        public string Format()
            => Content.IsNonEmpty ? string.Format("; {0}",Content) : EmptyString;

        public override string ToString()
            => Format();

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public static AsmComment Empty
        {
            [MethodImpl(Inline)]
            get => new AsmComment(TextBlock.Empty);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmComment(string src)
            => new AsmComment(src);

        [MethodImpl(Inline)]
        public static implicit operator string(AsmComment src)
            => src.Format();
    }
}