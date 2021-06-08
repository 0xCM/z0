//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmEncodingRule : ITextExpr<AsmEncodingRule>
    {
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmEncodingRule(string src)
            => Data = src;

        public TextBlock Content
        {
            [MethodImpl(Inline)]
            get => Data.Text;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmEncodingRule src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is AsmEncodingRule x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator AsmEncodingRule(string src)
            => new AsmEncodingRule(src);

        public static AsmEncodingRule Empty
            => new AsmEncodingRule(EmptyString);
    }
}