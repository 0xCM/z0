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
    
    public readonly struct CpuidExpression : ISymbolic<CpuidExpression,AsciCode16>
    {
        public AsciCode16 Data {get;}

        public static CpuidExpression Empty 
            => new CpuidExpression(new char[0]{});

        [MethodImpl(Inline)]
        public static implicit operator CpuidExpression(string src)
            => new CpuidExpression(src);

        [MethodImpl(Inline)]
        public static implicit operator CpuidExpression(char[] src)
            => new CpuidExpression(src);

        [MethodImpl(Inline)]
        public CpuidExpression(AsciCode16 src)
            => Data = src;

        [MethodImpl(Inline)]
        public CpuidExpression(string src)
            => Data = Symbolic.encode(src, ASCI, n16);

        [MethodImpl(Inline)]
        public CpuidExpression(char[] src)
            => Data = Symbolic.encode(src, ASCI, n16);

        public CpuidExpression Zero 
            => Empty;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

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
        public bool Equals(CpuidExpression src)
            => src.Data.Equals(Data);
        
        public override bool Equals(object src)
            => src is CpuidExpression x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();        
        public string Format()
            => Data.Format();
        
        public override string ToString()
            => Format();
    }
}