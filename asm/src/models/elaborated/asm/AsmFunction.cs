//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;             

    /// <summary>
    /// Describes the assembly encoding for a function
    /// </summary>
    public class AsmFunction
    {           
        public static AsmFunction Define(OpDescriptor op, MemoryRange memory, AsmCode code, CaptureOutcome ci, AsmInstructionList instructions)
            => new AsmFunction(op, memory, code, ci, instructions);

        AsmFunction(OpDescriptor op, MemoryRange address, AsmCode code, CaptureOutcome ci, AsmInstructionList instructions)
        {
            this.Id = code.Id;
            this.Operation = op;
            this.Instructions = instructions;
            this.Code = code;            
            this.SourceMemory = address;
            this.CaptureInfo = ci;
        }

        /// <summary>
        /// The defining operation
        /// </summary>
        public OpDescriptor Operation {get;}

        /// <summary>
        /// The function identifier
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The function encoding
        /// </summary>
        public AsmCode Code {get;}

        /// <summary>
        /// The memory location from which the code was taken
        /// </summary>
        public MemoryRange SourceMemory {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionList Instructions {get;}            
        
        /// <summary>
        /// The defining CIL
        /// </summary>
        public Option<CilFunction> Cil {get; private set;}
        
        /// <summary>
        /// Describes the capture outcome
        /// </summary>
        public CaptureOutcome CaptureInfo {get;}

        /// <summary>
        /// The definining operation uri
        /// </summary>
        public OpUri Uri
        {
            [MethodImpl(Inline)]
            get =>  Operation.Uri;
        }

        /// <summary>
        /// The location in memory at which the function definition begins
        /// </summary>
        public MemoryAddress StartAddress
        {
            [MethodImpl(Inline)]
            get => SourceMemory.Start;
        }

        /// <summary>
        /// The location in memory at which the function definition ends
        /// </summary>
        public MemoryAddress EndAddress
        {
            [MethodImpl(Inline)]
            get => SourceMemory.Start;
        }

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;            
        }

        public AsmFunction WithCil(CilFunction cil)            
        {            
            this.Cil = cil;
            return this;
        }

        public AsmFunction WithCil(Option<CilFunction> cil)            
        {            
            this.Cil = cil;
            return this;
        }
    }
}
