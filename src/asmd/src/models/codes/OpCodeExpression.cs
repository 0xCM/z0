//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    public readonly struct OpCodeExpression : IAsmExpression<OpCodeExpression,string>
    {
        readonly string Source;

        public static OpCodeExpression Empty 
            => new OpCodeExpression(string.Empty);

        [MethodImpl(Inline)]
        public OpCodeExpression(string src)
        {
            Source = src;
        }        

        public string Content
        {
            [MethodImpl(Inline)]
            get => Source ?? string.Empty;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public OpCodeExpression Zero 
            => Empty;

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.empty(Content);
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => !text.empty(Content);
        }

        [MethodImpl(Inline)]
        public bool Equals(OpCodeExpression src)
            => string.Equals(Content, src.Content, NoCase);
        
        public override bool Equals(object src)
            => src is OpCodeExpression x && Equals(x);
        
        public override int GetHashCode()
            => Content.GetHashCode();
        
        public string Format()
            => Content;
        
        public override string ToString()
            => Format();
    }
}