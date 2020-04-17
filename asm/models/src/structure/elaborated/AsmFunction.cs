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
        public static AsmFunction Empty => new AsmFunction(OpUri.Empty, string.Empty, LocatedBits.Empty, 0, AsmInstructionList.Empty);

        public static AsmFunction Define(ParsedMember encoding,  AsmInstructionList instructions)
        {         
            var code = LocatedBits.Define(encoding.MemberUri.OpId, encoding.Content);
            return new AsmFunction(encoding.MemberUri, encoding.MemberSig, code, encoding.TermCode, instructions);
        }

        public static AsmFunction Define(ParsedExtract encoding,  AsmInstructionList instructions)
        {         
            var code = LocatedBits.Define(encoding.Id, encoding.ParsedContent);  
            var sig = encoding.SourceMember.Signature().Format();          
            return new AsmFunction(encoding.Uri, sig, code, encoding.TermCode, instructions);
        }

        AsmFunction(OpUri uri, string sig, LocatedBits code, ExtractTermCode term, AsmInstructionList instructions)
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
        public LocatedBits Code {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionList Instructions {get;}            

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public ExtractTermCode TermCode {get;}

        /// <summary>
        /// The memory segment from which the function was extracted
        /// </summary>
        public MemoryRange AddressRange
        {
            [MethodImpl(Inline)]
            get => Code.Location;    
        }

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
