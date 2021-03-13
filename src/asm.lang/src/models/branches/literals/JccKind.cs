//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static JmpFacets;

    /// <summary>
    /// Classifies Jmp instruction variations
    /// </summary>
    [Flags]
    public enum JccKind : ulong
    {
        None = 0,

        /// <summary> Jump if Above; CF=0 and ZF=0 </summary>
        JA = JCC,

        /// <summary> Jump if Above or Equal; CF=0 </summary>
        JAE = 2*JCC,

        /// <summary> Jump if Below; CF=1 </summary>
        JB = 3*JCC,

        /// <summary> Jump if Below or Equal; CF=1 or ZF=1 </summary>
        JBE = 4*JCC,

        /// <summary> Jump if Carry; CF=1 </summary>
        JC = 5*JCC,

        /// <summary> Jump if CX Zero; CX=0 </summary>
        JCXZ = 6*JCC,

        /// <summary> Jump if Equal; ZF=1 </summary>
        JE = 7*JCC,

        /// <summary> Jump if Greater (signed); ZF=0 and SF=OF </summary>
        JG = 8*JCC,

        /// <summary> Jump if Greater or Equal (signed); SF=OF </summary>
        JGE = 9*JCC,

        /// <summary> Jump if Less (signed); SF != OF </summary>
        JL = 10*JCC,

        /// <summary> Jump if Less or Equal (signed) ;ZF=1 or SF != OF </summary>
        JLE = 11*JCC,

        /// <summary> Jump if Not Above; CF=1 or ZF=1 </summary>
        JNA = 12*JCC,

        /// <summary> Jump if Not Above or Equal; CF=1 </summary/>
        JNAE = 13*JCC,

        /// <summary> Jump if Not Below; CF=0 </summary/>
        JNB = 14*JCC,

        /// <summary> Jump if Not Below or Equal; CF=0 and ZF=0 </summary>
        JNBE = 15*JCC,

        /// <summary> Jump if Not Carry; CF=0 </summary/>
        JNC = 16*JCC,

        /// <summary> Jump if Not Equal; ZF=0 </summary/>
        JNE = 17*JCC,

        /// <summary> Jump if Not Greater (signed); ZF=1 or SF != OF </summary>
        JNG = 18*JCC,

        /// <summary> Jump if Not Greater or Equal (signed); SF != OF </summary>
        JNGE = 19*JCC,

        /// <summary> Jump if Not Less (signed); SF=OF </summary>
        JNL = 20*JCC,

        /// <summary> Jump if Not Less or Equal (signed); ZF=0 and SF=OF </summary>
        JNLE = 21*JCC,

        /// <summary> Jump if Not Overflow (signed); OF=0 </summary>
        JNO = 22*JCC,

        /// <summary> Jump if No Parity; PF=0 </summary/>
        JNP = 23*JCC,

        /// <summary> Jump if Not Signed (signed); SF=0 </summary>
        JNS = 24*JCC,

        /// <summary> Jump if Not Zero; ZF=0 </summary>
        JNZ = 25*JCC,

        /// <summary> Jump if Overflow (signed); OF=1 </summary>
        JO = 26*JCC,

        /// <summary> Jump if Parity; PF=1 </summary>
        JP = 27*JCC,

        /// <summary> Jump if Parity Even; PF=1 </summary>
        JPE = 28*JCC,

        /// <summary> Jump if Parity Odd; PF=0 </summary>
        JPO = 29*JCC,

        /// <summary> Jump if Signed (signed); SF=1 </summary>
        JS = 30*JCC,

        /// <summary> Jump if Zero; ZF=1 </summary>
        JZ = 31*JCC,
    }
}