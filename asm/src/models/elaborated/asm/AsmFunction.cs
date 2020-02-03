//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;             

    /// <summary>
    /// Describes the assembly encoding for a function
    /// </summary>
    public class AsmFunction
    {   
        public static AsmFunction Define(MemoryRange origin, AsmCode code, NativeCaptureInfo ci, AsmInstructionList instructions)
            => new AsmFunction(origin, code, ci, instructions);

        AsmFunction(MemoryRange address, AsmCode code, NativeCaptureInfo ci, AsmInstructionList instructions)
        {
            this.Id = code.Id;
            this.Name = code.Id;
            this.Label = code.Label;
            this.Instructions = instructions;
            this.Code = code;            
            this.Location = address;
            this.CaptureInfo = ci;
        }

        /// <summary>
        /// The function identifier
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The function name
        /// </summary>
        public string Name {get;}
        
        /// <summary>
        /// Descriptive text such as a function signature
        /// </summary>
        public string Label {get;}

        /// <summary>
        /// The function encoding
        /// </summary>
        public AsmCode Code {get;}

        /// <summary>
        /// The memory location from which the code was taken
        /// </summary>
        public MemoryRange Location {get;}

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
        public NativeCaptureInfo CaptureInfo {get;}

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
            => Instructions.Length;            

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
