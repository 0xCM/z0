//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmOpCodeInfo : ITextExpression<AsmOpCodeInfo>
    {
        public string Body {get;}

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(AsmOpCodeInfo src)
            => new TextExpression(src.Body);

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeInfo(string src)
            => new AsmOpCodeInfo(src);

        [MethodImpl(Inline)]
        public AsmOpCodeInfo(string src)
            => Body = src;

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => Body;
        }

        public AsmOpCodeInfo Zero 
            => Empty;

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.blank(Body);
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => !text.blank(Body);
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeInfo src)
            => string.Equals(Body, src.Body, NoCase);
        
        public override bool Equals(object src)
            => src is AsmOpCodeInfo x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();
        
        public string Format()
            => Body;
        
        public override string ToString()
            => Format();

        public static AsmOpCodeInfo Empty 
            => new AsmOpCodeInfo(string.Empty);

    }
}