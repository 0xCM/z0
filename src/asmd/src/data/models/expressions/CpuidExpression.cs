//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    
    public readonly struct CpuidExpression : ISymbolic<CpuidExpression,asci16>
    {
        public asci16 Body {get;}

        public static CpuidExpression Empty => new CpuidExpression(asci16.Null);

        [MethodImpl(Inline)]
        public static implicit operator CpuidExpression(string src)
            => new CpuidExpression(src);

        [MethodImpl(Inline)]
        public CpuidExpression(asci16 src)
            => Body = src;

        [MethodImpl(Inline)]
        public CpuidExpression(string src)
            => Body = asci.encode(n16, src);

        [MethodImpl(Inline)]
        public CpuidExpression(char[] src)
            => Body = asci.encode(n16, src);

        [Ignore]
        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(Body);
        }

        [Ignore]
        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Body);
        }

        public CpuidExpression Zero 
            => Empty;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Body.Length;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Body.IsEmpty;
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => Body.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(CpuidExpression src)
            => src.Body.Equals(Body);
        
        public override bool Equals(object src)
            => src is CpuidExpression x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();        
        public string Format()
            => Body.Format();
        
        public override string ToString()
            => Format();
    }
}