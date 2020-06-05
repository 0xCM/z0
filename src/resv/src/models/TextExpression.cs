//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public readonly struct TextExpression : ITextExpression<TextExpression>
    {
        public static TextExpression Empty 
            => new TextExpression(string.Empty);

        public string Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(string src)
            => new TextExpression(src);

        [MethodImpl(Inline)]
        public TextExpression(string src)
            => Data = src;

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public TextExpression Zero 
            => Empty;

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.empty(Data);
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => !text.empty(Data);
        }

        [MethodImpl(Inline)]
        public bool Equals(TextExpression src)
            => string.Equals(Data, src.Data, NoCase);
        
        public override bool Equals(object src)
            => src is TextExpression x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public string Format()
            => Data;
        
        public override string ToString()
            => Format();
    }
}