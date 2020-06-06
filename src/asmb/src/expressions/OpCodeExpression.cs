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
    
    public readonly struct OpCodeExpression : ISymbolic<OpCodeExpression,AsciCode32>
    {
        public AsciCode32 Data {get;}

        public static OpCodeExpression Empty 
            => new OpCodeExpression(new char[0]{});

        [MethodImpl(Inline)]
        public static implicit operator OpCodeExpression(string src)
            => new OpCodeExpression(src);

        [MethodImpl(Inline)]
        public static implicit operator OpCodeExpression(char[] src)
            => new OpCodeExpression(src);

        [MethodImpl(Inline)]
        public OpCodeExpression(string src)
            => Data = Symbolic.encode(src, ASCI, n32);

        [MethodImpl(Inline)]
        public OpCodeExpression(char[] src)
            => Data = Symbolic.encode(src, ASCI, n32);

        public OpCodeExpression Zero 
            => Empty;


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

        [MethodImpl(Inline)]
        public bool Equals(OpCodeExpression src)
            => src.Data.Equals(Data);
        
        public override bool Equals(object src)
            => src is OpCodeExpression x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();        
        public string Format()
            => Data.Format();
        
        public override string ToString()
            => Format();
    }
}