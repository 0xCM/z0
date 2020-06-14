//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
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
    public readonly struct InstructionExpression  : ISymbolic<InstructionExpression,asci64>
    {
        public asci64 Body {get;}

        public static InstructionExpression Empty => new InstructionExpression(asci64.Null);

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(InstructionExpression src)
            => new TextExpression(src.Body.Format());

        [MethodImpl(Inline)]
        public static implicit operator InstructionExpression(string src)
            => new InstructionExpression(src);

        [MethodImpl(Inline)]
        public InstructionExpression(string src)
            => Body = src;

        [MethodImpl(Inline)]
        public InstructionExpression(asci64 src)
            => Body = src;

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

        public InstructionExpression Zero 
            => Empty;
        
        [MethodImpl(Inline)]
        public bool Equals(InstructionExpression src)
             => src.Body.Equals(Body);
       
        public override bool Equals(object src)
            => src is InstructionExpression x && Equals(x);
        
        public override int GetHashCode()
            => Body.GetHashCode();
        
        public string Format()
            => Body.Format();
        
        public override string ToString()
            => Format();
    }
}