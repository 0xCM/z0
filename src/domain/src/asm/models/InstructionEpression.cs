//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Represents an expression that identifies an instruction
    /// </summary>
    /// <remarks>
    /// Instruction expressions are of the form
    /// 0 operands: {Mnemonic}
    /// 1 operand: {Mnemonic}{ }{op1}
    /// 2 operands: {Mnemonic}{ }{op1}{,}{op2}
    /// 3 operands: {Mnemonic}{ }{op1}{,}{op2},{op3}
    /// Example: PCMPISTRI xmm1, xmm2/m128, imm8  
    /// <remarks>
    public readonly struct InstructionExpression
    {
        public readonly asci64 Value;
        
        [MethodImpl(Inline)]
        public static implicit operator TextExpression(InstructionExpression src)
            => new TextExpression(src.Value.Format());

        [MethodImpl(Inline)]
        public static implicit operator InstructionExpression(string src)
            => new InstructionExpression(src);

        [MethodImpl(Inline)]
        public InstructionExpression(string src)
            => asci.encode(src, out Value);

        [MethodImpl(Inline)]
        public InstructionExpression(asci64 src)
            => Value = src;

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

        public InstructionExpression Zero 
            => Empty;
        
        [MethodImpl(Inline)]
        public bool Equals(InstructionExpression src)
             => src.Value.Equals(Value);
       
        public override bool Equals(object src)
            => src is InstructionExpression x && Equals(x);
        
        public override int GetHashCode()
            => Value.GetHashCode();
        
        public string Format()
            => Value.Format();
        
        public override string ToString()
            => Format();

        public static InstructionExpression Empty 
            => new InstructionExpression(asci.Null);
    }
}