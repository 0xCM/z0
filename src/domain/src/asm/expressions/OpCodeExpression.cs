//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct OpCodeExpression
    {
        public readonly asci32 Value;

        [MethodImpl(Inline)]
        public static implicit operator OpCodeExpression(string src)
            => AsmOpCodes.expression(src);

        [MethodImpl(Inline)]
        public OpCodeExpression(asci32 src)
            => Value = src;

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => asci.bytes(Value);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Value);
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
        public bool Equals(OpCodeExpression src)
            => src.Value.Equals(Value);
        
        public override bool Equals(object src)
            => src is OpCodeExpression x && Equals(x);
        
        public override int GetHashCode()
            => Value.GetHashCode();        
        
        public string Format()
            => Value.Format();
        
        public override string ToString()
            => Format();

        public static OpCodeExpression Empty 
            => new OpCodeExpression(asci32.Null);
    }
}