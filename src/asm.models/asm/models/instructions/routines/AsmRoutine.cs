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
    /// Describes the assembly encoding of a member api
    /// </summary>
    public class AsmRoutine
    {           
        /// <summary>
        /// The defining operation uri
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The function identifier
        /// </summary>
        public OpIdentity OpId {get;}

        /// <summary>
        /// The source member signature
        /// </summary>
        public string OpSig {get;}
        
        /// <summary>
        /// The function encoding
        /// </summary>
        public MemberCode Code {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmFxList Instructions {get;}            

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public ExtractTermCode TermCode {get;}

        [MethodImpl(Inline)]
        public AsmRoutine(OpUri uri, string sig, MemberCode code, ExtractTermCode term, AsmFxList instructions)
        {
            Uri = uri;
            OpId = uri.OpId;
            OpSig = sig;
            Instructions = instructions;
            Code = code;            
            TermCode =term;
        }

        /// <summary>
        /// The head of the address range
        /// </summary>
        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Code.Address;
        }

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;            
        }

        public bool IsEmpty 
            => InstructionCount == 0;

        public bool IsNonEmpty 
            => InstructionCount != 0;


        public static AsmRoutine Empty 
            => new AsmRoutine(OpUri.Empty, string.Empty, MemberCode.Empty, 0, AsmFxList.Empty);
    }
}