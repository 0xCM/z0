//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
                

    /// <summary>
    /// Describes the assembly encoding for a function
    /// </summary>
    public class AsmFunction
    {   
        public static AsmFunction Define(MemoryRange origin, AsmCode code, CaptureTermReason reason, AsmInstructionInfo[] instructions, CilFunction cil = null)
            => new AsmFunction(origin, code, reason, instructions,cil);

        AsmFunction(MemoryRange address, AsmCode code, CaptureTermReason reason, AsmInstructionInfo[] instructions, CilFunction cil)
        {
            this.Id = code.Id;
            this.Name = code.Id;
            this.Label = code.Label;
            this.Instructions = instructions;
            this.Code = code;
            this.TermReason = reason;
            this.Location = address;
            this.Cil = cil;            
        }

        /// <summary>
        /// The function identifier
        /// </summary>
        public Moniker Id {get;}

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
        public AsmInstructionInfo[] Instructions {get;}            
        
        /// <summary>
        /// The defining CIL
        /// </summary>
        public Option<CilFunction> Cil {get;}
        
        /// <summary>
        /// The reason discerned for capture completion
        /// </summary>
        public CaptureTermReason TermReason {get;}

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
            => Instructions.Length;            
    }
}
