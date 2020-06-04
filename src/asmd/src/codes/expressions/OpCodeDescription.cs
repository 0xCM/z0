//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OpCodeDescription : ITextExpression<OpCodeDescription>
    {
        public string Data {get;}

        public static OpCodeDescription Empty 
            => new OpCodeDescription(string.Empty);

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(OpCodeDescription src)
            => new TextExpression(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator OpCodeDescription(string src)
            => new OpCodeDescription(src);

        [MethodImpl(Inline)]
        public OpCodeDescription(string src)
            => Data = src;

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public OpCodeDescription Zero 
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
        public bool Equals(OpCodeDescription src)
            => string.Equals(Data, src.Data, NoCase);
        
        public override bool Equals(object src)
            => src is OpCodeDescription x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public string Format()
            => Data;
        
        public override string ToString()
            => Format();
    }

}