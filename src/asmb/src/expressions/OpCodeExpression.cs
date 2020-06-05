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
    
    public readonly struct OpCodeExpression : ITextExpression<OpCodeExpression>
    {
        public string Data {get;}

        public static OpCodeExpression Empty 
            => new OpCodeExpression(string.Empty);

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(OpCodeExpression src)
            => new TextExpression(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator OpCodeExpression(string src)
            => new OpCodeExpression(src);

        [MethodImpl(Inline)]
        public OpCodeExpression(string src)
            => Data = src;

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public OpCodeExpression Zero 
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
        public bool Equals(OpCodeExpression src)
            => string.Equals(Data, src.Data, NoCase);
        
        public override bool Equals(object src)
            => src is OpCodeExpression x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public string Format()
            => Data;
        
        public override string ToString()
            => Format();
    }
}