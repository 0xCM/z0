//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    
    public enum AsmDataField
    {
        /// <summary>
        /// The ice opcode identifer
        /// </summary>
        OpCodeId,

        /// <summary>
        /// A unique 0-based sequence number
        /// </summary>
        Sequence, 

        /// <summary>
        /// The instruction mnemonic
        /// </summary>
        Mnemonic, 

        /// <summary>
        /// The first instruction operand
        /// </summary>
        Op0, 

        /// <summary>
        /// "The second instruction operand"
        /// </summary>
        Op1,    

        /// <summary>
        /// The third instruction operand
        /// </summary>
        Op2,  

        /// <summary>
        /// The fourth instruction operand
        /// </summary>
        Op3,    

        /// <summary>
        /// The fifth instruction operand
        /// </summary>
        Op4,    

        /// <summary>
        /// The ice opcode identifer
        /// </summary>
        CpuId,
    }
}