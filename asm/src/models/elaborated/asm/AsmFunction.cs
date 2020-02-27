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
        public static AsmFunction Define(OpDescriptor op, AsmCode code, CaptureOutcome ci, AsmInstructionList instructions)
            => new AsmFunction(op, code, ci, instructions);

        public static AsmFunction Define(ParsedEncoding encoding, CaptureOutcome ci, AsmInstructionList instructions)
        {         
            var code = AsmCode.Define(encoding.Operation.Id, encoding.AddressRange, encoding.ParsedData);
            return new AsmFunction(encoding.Operation, code, ci,instructions);
        }

        AsmFunction(OpDescriptor op, AsmCode code, CaptureOutcome ci, AsmInstructionList instructions)
        {
            this.Id = op.Id;
            this.Operation = op;
            this.Instructions = instructions;
            this.Code = code;            
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
        /// The encoded instructions
        /// </summary>
        public AsmInstructionList Instructions {get;}            
                
        /// <summary>
        /// Describes the capture outcome
        /// </summary>
        public CaptureOutcome CaptureInfo {get;}

        /// <summary>
        /// The defining CIL
        /// </summary>
        public Option<CilFunction> Cil {get; private set;}

        /// <summary>
        /// The memory location from which the code was taken
        /// </summary>
        public MemoryRange AddressRange
        {
            [MethodImpl(Inline)]
            get => Code.AddressRange;
        }

        /// <summary>
        /// The definining operation uri
        /// </summary>
        public OpUri Uri
        {
            [MethodImpl(Inline)]
            get => Operation.Uri;
        }

        /// <summary>
        /// The location in memory at which the function definition begins
        /// </summary>
        public MemoryAddress StartAddress
        {
            [MethodImpl(Inline)]
            get => AddressRange.Start;
        }

        /// <summary>
        /// The location in memory at which the function definition ends
        /// </summary>
        public MemoryAddress EndAddress
        {
            [MethodImpl(Inline)]
            get => AddressRange.End;
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
