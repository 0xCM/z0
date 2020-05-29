//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    /// <summary>
    /// Classifies Jmp instruction variations
    /// </summary>
    [Flags]
    public enum JmpKind : ulong
    {
        None = 0,
        /// <summary> Jump if Above; CF=0 and ZF=0 </summary>
        JA = 1,

        /// <summary> Jump if Above or Equal; CF=0 </summary>       
        JAE = 2*JA,

        /// <summary> Jump if Below; CF=1 </summary>
        JB = 2*JAE,

        /// <summary> Jump if Below or Equal; CF=1 or ZF=1 </summary>
        JBE = 2*JB,
        
        /// <summary> Jump if Carry; CF=1 </summary>
        JC = 2*JBE,

        /// <summary> Jump if CX Zero; CX=0 </summary>       
        JCXZ = 2*JC,

        /// <summary> Jump if Equal; ZF=1 </summary>
        JE = 2*JCXZ,       

        /// <summary> Jump if Greater (signed); ZF=0 and SF=OF </summary>
        JG = 2*JE,

        /// <summary> Jump if Greater or Equal (signed); SF=OF </summary>
        JGE = 2*JG,

        /// <summary> Jump if Less (signed); SF != OF </summary>
        JL = 2*JGE,

        /// <summary> Jump if Less or Equal (signed) ;ZF=1 or SF != OF </summary>
        JLE = 2*JL,

        /// <summary> Unconditional Jump; unconditional </summary>
        JMP = 2*JLE,

        /// <summary> Jump if Not Above; CF=1 or ZF=1 </summary>
        JNA = 2*JMP,

        /// <summary> Jump if Not Above or Equal; CF=1 </summary/>
        JNAE = 2*JNA,

        /// <summary> Jump if Not Below; CF=0 </summary/>
        JNB = 2*JNAE,

        /// <summary> Jump if Not Below or Equal; CF=0 and ZF=0 </summary>
        JNBE = 2*JNB,

        /// <summary> Jump if Not Carry; CF=0 </summary/>
        JNC = 2*JNBE,

        /// <summary> Jump if Not Equal; ZF=0 </summary/>
        JNE = 2*JNC,

        /// <summary> Jump if Not Greater (signed); ZF=1 or SF != OF </summary>
        JNG = 2*JNE,

        /// <summary> Jump if Not Greater or Equal (signed); SF != OF </summary>
        JNGE = 2*JNG,

        /// <summary> Jump if Not Less (signed); SF=OF </summary>
        JNL = 2*JNGE,

        /// <summary> Jump if Not Less or Equal (signed); ZF=0 and SF=OF </summary>
        JNLE = 2*JNL,

        /// <summary> Jump if Not Overflow (signed); OF=0 </summary>
        JNO = 2*JNLE,

        /// <summary> Jump if No Parity; PF=0 </summary/>
        JNP = 2*JNO,

        /// <summary> Jump if Not Signed (signed); SF=0 </summary>
        JNS = 2*JNP,      

        /// <summary> Jump if Not Zero; ZF=0 </summary>
        JNZ = 2*JNS,

        /// <summary> Jump if Overflow (signed); OF=1 </summary>
        JO = 2*JNZ,

        /// <summary> Jump if Parity; PF=1 </summary>
        JP = 2*JO,

        /// <summary> Jump if Parity Even; PF=1 </summary>
        JPE = 2*JP,

        /// <summary> Jump if Parity Odd; PF=0 </summary>
        JPO = 2*JPE,

        /// <summary> Jump if Signed (signed); SF=1 </summary>
        JS = 2*JPO,

        /// <summary> Jump if Zero; ZF=1 </summary>
        JZ = 2*JS,

        Max = JZ       
    }
}