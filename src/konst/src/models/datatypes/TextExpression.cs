//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct TextExpression : ITextExpression<TextExpression>
    {
        public string Body {get;}

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(string src)
            => new TextExpression(src);

        [MethodImpl(Inline)]
        public TextExpression(string src)
            => Body = src;

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => Body;
        }

        public TextExpression Zero 
            => Empty;

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => sys.blank(Body);
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => !sys.blank(Body);
        }

        [MethodImpl(Inline)]
        public bool Equals(TextExpression src)
            => string.Equals(Body, src.Body, NoCase);
        
        public override bool Equals(object src)
            => src is TextExpression x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();
        
        public string Format()
            => Body;
        
        public override string ToString()
            => Format();

        public static TextExpression Empty 
            => new TextExpression(string.Empty);
    }
}