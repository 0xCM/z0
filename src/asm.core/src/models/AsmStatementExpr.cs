//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct AsmStatementExpr : IEquatable<AsmStatementExpr>
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmStatementExpr(TextBlock content)
            => Content = content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public string FormatFixed()
            => string.Format("{0,-46}", Content);

        [MethodImpl(Inline)]
        public bool Equals(AsmStatementExpr src)
            => Content.Equals(src.Content);

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is AsmStatementExpr x && Equals(x);

        public BinaryCode Serialize()
        {
            var count = Content.Length;
            if(count != 0)
            {
                var buffer = alloc<byte>(Content.Length);
                ref var dst = ref first(buffer);
                var src = Content.View;
                for(var i=0; i<count; i++)
                    seek(dst,i) = (byte)skip(src,i);
                return buffer;
            }
            else
                return BinaryCode.Empty;
        }

        public AsmStatementExpr Replace(string src, string dst)
            => new AsmStatementExpr(Content.Replace(src,dst));

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }

        public int CompareTo(AsmStatementExpr src)
            => Content.CompareTo(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementExpr(string src)
            => new AsmStatementExpr(src);

        public static AsmStatementExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmStatementExpr(TextBlock.Empty);
        }
    }
}