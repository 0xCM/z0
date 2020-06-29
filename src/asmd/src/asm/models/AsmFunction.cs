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
    public class AsmFunction
    {           
        public static AsmFunction define(ParsedExtract encoding,  AsmInstructionList inxs)
        {         
            var code = MemberCode.Define(encoding.OpUri, encoding.Encoded);  
            var sig = encoding.Method.Signature().Format();          
            return new AsmFunction(encoding.OpUri, sig, code, encoding.TermCode, inxs);
        }

        [MethodImpl(Inline)]
        public static AsmFunction define(OpUri uri, string sig, MemberCode code, ExtractTermCode term, AsmInstructionList inxs)
            => new AsmFunction(uri,sig,code,term,inxs);

        internal AsmFunction(OpUri uri, string sig, MemberCode code, ExtractTermCode term, AsmInstructionList instructions)
        {
            Uri = uri;
            OpId = uri.OpId;
            OpSig = sig;
            Inxs = instructions;
            Code = code;            
            TermCode =term;
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
        public MemberCode Code {get;}

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

        public bool IsEmpty 
            => InstructionCount == 0;

        public bool IsNonEmpty 
            => InstructionCount != 0;

        public static AsmFunction Empty 
            => new AsmFunction(OpUri.Empty, string.Empty, MemberCode.Empty, 0, AsmInstructionList.Empty);
    }
}