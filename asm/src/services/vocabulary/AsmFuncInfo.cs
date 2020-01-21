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
    public class AsmFuncInfo
    {   
        public static AsmFuncInfo Define(MemoryRange location, AsmCode code, AsmInstructionInfo[] instructions)
            => new AsmFuncInfo(location, code, instructions);

        AsmFuncInfo(MemoryRange address, AsmCode code, AsmInstructionInfo[] instructions)
        {
            this.Id = code.Id;
            this.Name = code.Id;
            this.Label = code.Label;
            this.Instructions = instructions;
            this.Code = code;
            this.Location = address;
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
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
            => Instructions.Length;
    }
}
