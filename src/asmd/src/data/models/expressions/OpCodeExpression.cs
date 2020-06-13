//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    
    public readonly struct OpCodeExpression : ISymbolic<OpCodeExpression,asci32>
    {
        public asci32 Body {get;}

        public static OpCodeExpression Empty => new OpCodeExpression(asci32.Null);

        [MethodImpl(Inline)]
        public static implicit operator OpCodeExpression(string src)
            => new OpCodeExpression(src);

        [MethodImpl(Inline)]
        public OpCodeExpression(string src)
            => Body = asci.encode(n32, src);

        [MethodImpl(Inline)]
        public OpCodeExpression(asci32 src)
            => Body = src;

        [MethodImpl(Inline)]
        public OpCodeExpression(char[] src)
            => Body = asci.encode(n32, src);

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(Body);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Body);
        }
        
        public OpCodeExpression Zero 
            => Empty;

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
        public bool Equals(OpCodeExpression src)
            => src.Body.Equals(Body);
        
        public override bool Equals(object src)
            => src is OpCodeExpression x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();        
        public string Format()
            => Body.Format();
        
        public override string ToString()
            => Format();
    }
}