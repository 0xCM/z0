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
    
    public readonly struct InstructionExpression : IAsmExpression<InstructionExpression,string>
    {
        readonly string Source;

        public static InstructionExpression Empty 
            => new InstructionExpression(string.Empty);

        [MethodImpl(Inline)]
        public InstructionExpression(string src)
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

        public InstructionExpression Zero 
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
        public bool Equals(InstructionExpression src)
            => string.Equals(Content, src.Content, NoCase);
        
        public override bool Equals(object src)
            => src is InstructionExpression x && Equals(x);
        
        public override int GetHashCode()
            => Content.GetHashCode();
        
        public string Format()
            => Content;
        
        public override string ToString()
            => Format();
    }
}