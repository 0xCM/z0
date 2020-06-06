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
    public readonly struct InstructionExpression  : ISymbolic<InstructionExpression,AsciCode64>
    {
        public AsciCode64 Data {get;}

        public static InstructionExpression Empty  => new InstructionExpression(AsciCode64.Null);

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(InstructionExpression src)
            => new TextExpression(src.Data.Format());

        [MethodImpl(Inline)]
        public static implicit operator InstructionExpression(string src)
            => new InstructionExpression(src);

        [MethodImpl(Inline)]
        public InstructionExpression(string src)
            => Data = src;

        [MethodImpl(Inline)]
        public InstructionExpression(AsciCode64 src)
            => Data = src;

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

        public InstructionExpression Zero 
            => Empty;
        
        [MethodImpl(Inline)]
        public bool Equals(InstructionExpression src)
             => src.Data.Equals(Data);
       
        public override bool Equals(object src)
            => src is InstructionExpression x && Equals(x);
        
        public override int GetHashCode()
            => Data.GetHashCode();
        
        public string Format()
            => Data.Format();
        
        public override string ToString()
            => Format();
    }
}