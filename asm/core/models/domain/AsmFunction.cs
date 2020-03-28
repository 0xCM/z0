//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    /// <summary>
    /// Describes the assembly encoding for a function
    /// </summary>
    public class AsmFunction
    {           
        public static AsmFunction Empty => new AsmFunction(ApiMemberInfo.Empty, AsmCode.Empty, 0, AsmInstructionList.Empty);

        public static AsmFunction Define(ParsedOpExtract encoding,  AsmInstructionList instructions)
        {         
            var code = AsmCode.Define(encoding.Operation.Id, encoding.Content);
            return new AsmFunction(encoding.Operation, code, encoding.TermCode, instructions);
        }

        public static AsmFunction Define(ParsedExtract encoding,  AsmInstructionList instructions)
        {         
            var code = AsmCode.Define(encoding.Id, encoding.ParsedContent);            
            return new AsmFunction(encoding.Descriptor, code, encoding.TermCode, instructions);
        }

        AsmFunction(ApiMemberInfo op, AsmCode code, ExtractTermCode term, AsmInstructionList instructions)
        {
            this.Id = op.Id;
            this.Operation = op;
            this.Instructions = instructions;
            this.Code = code;            
            this.TermCode =term;
        }

        /// <summary>
        /// The defining operation
        /// </summary>
        public ApiMemberInfo Operation {get;}

        /// <summary>
        /// The function identifier
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The function encoding
        /// </summary>
        public AsmCode Code {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionList Instructions {get;}            

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public ExtractTermCode TermCode {get;}

        /// <summary>
        /// The definining operation uri
        /// </summary>
        public OpUri Uri
        {
            [MethodImpl(Inline)]
            get => Operation.Uri;
        }

        /// <summary>
        /// The memory segment from which the function was extracted
        /// </summary>
        public MemoryRange AddressRange
        {
            [MethodImpl(Inline)]
            get => Code.AddressRange;    
        }

        /// <summary>
        /// The head of the address range
        /// </summary>
        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Code.AddressRange.Start;
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
    }
}
