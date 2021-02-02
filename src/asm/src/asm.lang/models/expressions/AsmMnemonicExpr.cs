//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmMnemonicExpr : ITextExpr<AsmMnemonicExpr>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public AsmMnemonicExpr(string src)
            => Content = src ?? EmptyString;

        public int Length
        {
            [MethodImpl(Inline)]
            get => text.length(Content);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        public override int GetHashCode()
            => text.hash(Content);

        [MethodImpl(Inline)]
        public string Format()
            => Content ?? EmptyString;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmMnemonicExpr src)
            => text.equals(Content, src.Content);

        public override bool Equals(object src)
            => src is AsmMnemonicExpr x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator AsmMnemonicExpr(string src)
            => new AsmMnemonicExpr(src);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmMnemonicExpr a, AsmMnemonicExpr b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmMnemonicExpr a, AsmMnemonicExpr b)
            => !a.Equals(b);

        public static AsmMnemonicExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmMnemonicExpr(TextBlock.Empty);
        }
    }
}