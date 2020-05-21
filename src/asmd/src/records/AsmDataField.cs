//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static Seed;

    public enum AsmDataField
    {
        [Comment("The ice opcode identifer")]
        OpCodeId,


        [Comment("A term of a monotonic integral sequence that identifies a record within some logical subset")]
        Sequence, 

        [Comment("An instruction mnemonic")]
        Mnemonic, 


        [Comment("The first instruction operand")]
        Op0, 

        [Comment("The second instruction operand")]
        Op1,    

        [Comment("The third instruction operand")]
        Op2,  

        [Comment("The fourth instruction operand")]
        Op3,    

        [Comment("The fifth instruction operand")]
        Op4,    

        CpuId,

    }

}