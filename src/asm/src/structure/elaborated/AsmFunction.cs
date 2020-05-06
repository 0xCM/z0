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
        public static AsmFunction Empty => new AsmFunction(OpUri.Empty, string.Empty, UriCode.Empty, 0, AsmInstructionList.Empty);

        public static AsmFunction Define(ParsedMember encoding,  AsmInstructionList inxs)
        {         
            var code = UriCode.Define(encoding.OpUri, encoding.Encoded);  
            var sig = encoding.Method.Signature().Format();          
            return new AsmFunction(encoding.OpUri, sig, code, encoding.TermCode, inxs);
        }

        [MethodImpl(Inline)]
        public static AsmFunction Define(OpUri uri, string sig, UriCode code, ExtractTermCode term, AsmInstructionList inxs)
            => new AsmFunction(uri,sig,code,term,inxs);

        AsmFunction(OpUri uri, string sig, UriCode code, ExtractTermCode term, AsmInstructionList instructions)
        {
            this.Uri = uri;
            this.OpId = uri.OpId;
            this.OpSig = sig;
            this.Inxs = instructions;
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
        public UriCode Code {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionList Inxs {get;}            

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
            get => Code.Address;
        }

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
        {
            [MethodImpl(Inline)]
            get => Inxs.Length;            
        }

        public bool IsEmpty => InstructionCount == 0;

        public bool IsNonEmpty => InstructionCount != 0;
    }
}
