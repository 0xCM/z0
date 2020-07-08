//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OpCodeDescription : ITextExpression<OpCodeDescription>
    {
        public string Body {get;}

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(OpCodeDescription src)
            => new TextExpression(src.Body);

        [MethodImpl(Inline)]
        public static implicit operator OpCodeDescription(string src)
            => new OpCodeDescription(src);

        [MethodImpl(Inline)]
        public OpCodeDescription(string src)
            => Body = src;

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => Body;
        }

        public OpCodeDescription Zero 
            => Empty;

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.empty(Body);
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => !text.empty(Body);
        }

        [MethodImpl(Inline)]
        public bool Equals(OpCodeDescription src)
            => string.Equals(Body, src.Body, NoCase);
        
        public override bool Equals(object src)
            => src is OpCodeDescription x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();
        
        public string Format()
            => Body;
        
        public override string ToString()
            => Format();

        public static OpCodeDescription Empty 
            => new OpCodeDescription(string.Empty);

    }
}