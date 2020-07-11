//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CpuidExpression
    {
        public readonly asci16 Value;

        [MethodImpl(Inline)]
        public static implicit operator CpuidExpression(string src)
            => new CpuidExpression(src);

        [MethodImpl(Inline)]
        public CpuidExpression(asci16 src)
            => Value = src;

        [MethodImpl(Inline)]
        public CpuidExpression(string src)
            => asci.encode(src, out Value);

        [MethodImpl(Inline)]
        public CpuidExpression(char[] src)
            => asci.encode(src, out Value);

        [Ignore]
        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => asci.bytes(Value);
        }

        [Ignore]
        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Value);
        }

        public CpuidExpression Zero 
            => Empty;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Value.Length;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Value.IsEmpty;
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => Value.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(CpuidExpression src)
            => src.Value.Equals(Value);
        
        public override bool Equals(object src)
            => src is CpuidExpression x && Equals(x);
        
        public override int GetHashCode()
            => Value.GetHashCode();        
        public string Format()
            => Value.Format();
        
        public override string ToString()
            => Format();

        public static CpuidExpression Empty 
            => new CpuidExpression(asci.Null);
    }
}