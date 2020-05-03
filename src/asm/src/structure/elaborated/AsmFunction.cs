//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Describes the assembly encoding of a member api
    /// </summary>
    public class AsmFunction
    {           
        public static AsmFunction Empty => new AsmFunction(OpUri.Empty, string.Empty, OperationBits.Empty, 0, AsmInstructionList.Empty);

        // public static AsmFunction Define(ParsedMember encoding,  AsmInstructionList instructions)
        // {         
        //     var code = OperationBits.Define(encoding.MemberUri, encoding.Content);
        //     return new AsmFunction(encoding.MemberUri, encoding.MemberSig, code, encoding.TermCode, instructions);
        // }

        public static AsmFunction Define(ParsedMember encoding,  AsmInstructionList instructions)
        {         
            var code = OperationBits.Define(encoding.Uri, encoding.ParsedContent);  
            var sig = encoding.Reflected.Signature().Format();          
            return new AsmFunction(encoding.Uri, sig, code, encoding.TermCode, instructions);
        }

        [MethodImpl(Inline)]
        public static AsmFunction Define(OpUri uri, string sig, OperationBits code, ExtractTermCode term, AsmInstructionList instructions)
            => new AsmFunction(uri,sig,code,term,instructions);

        AsmFunction(OpUri uri, string sig, OperationBits code, ExtractTermCode term, AsmInstructionList instructions)
        {
            this.Uri = uri;
            this.OpId = uri.OpId;
            this.OpSig = sig;
            this.Instructions = instructions;
            this.Code = code;            
            this.TermCode =term;
        }

        /// <summary>
        /// The definining operation uri
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
        public OperationBits Code {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionList Instructions {get;}            

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public ExtractTermCode TermCode {get;}

        /// <summary>
        /// The head of the address range
        /// </summary>
        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Code.Location.Start;
        }

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;            
        }

        public bool IsEmpty => InstructionCount == 0;

        public bool IsNonEmpty => InstructionCount != 0;
    }
}
