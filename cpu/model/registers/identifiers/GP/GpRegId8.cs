//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;


    /// <summary>
    /// Classifies 8-bit general purpose registers
    /// </summary>
    public enum GpRegId8 : uint
    {
        /// <summary>
        /// Identifies the 8-bit register AL = AX[7:0] = EAX[7:0] = RAX[7:0] 
        /// </summary>
        al = 0,

        /// <summary>
        /// Identifies the 8-bit register CL = CX[7:0] = ECX[7:0] = RCX[7:0]
        /// </summary>
        cl = al + 1,

        /// <summary>
        /// Identifies the 8-bit register DL = DX[7:0] = EDX[7:0] = RDX[7:0]
        /// </summary>
        dl = cl + 1,

        /// <summary>
        /// Identifies the 8-bit register BL = BX[7:0] = EBX[7:0] = RBX[7:0]
        /// </summary>
        bl = dl + 1,

        /// <summary>
        /// Identifies the 8-bit register AH = RAX[15:7]
        /// </summary>
        ah =  bl + 1,

        /// <summary>
        /// Identifies the 8-bit register CH = RCX[15:7]
        /// </summary>
        ch = ah + 1,

        /// <summary>
        /// Identifies the 8-bit register DH = RDX[15:7]
        /// </summary>
        dh = ch + 1,

        /// <summary>
        /// Identifies the 8-bit register BH = RBX[15:7]
        /// </summary>
        bh = dh + 1,

        /// <summary>
        /// Identifies the 8-bit register R8b = R8[7:0]
        /// </summary>
        r8b = bh + 1,

        /// <summary>
        /// Identifies the 8-bit register R9b = R9[7:0]
        /// </summary>
        r9b = r8b + 1,

        /// <summary>
        /// Identifies the 8-bit register R10b = R10[7:0]
        /// </summary>
        r10b = r9b + 1,

        /// <summary>
        /// Identifies the 8-bit register R11b = R11[7:0]
        /// </summary>
        r11b = r10b + 1,

        /// <summary>
        /// Identifies the 8-bit register R12b = R12[7:0]
        /// </summary>
        r12b = r11b + 1,

        /// <summary>
        /// Identifies the 8-bit register R13b = R13[7:0]
        /// </summary>
        r13b = r12b + 1,

        /// <summary>
        /// Identifies the 8-bit register R14b = R14[7:0]
        /// </summary>
        r14b = r13b + 1,

        /// <summary>
        /// Identifies the 8-bit register R15b = R15[7:0]
        /// </summary>
        r15b = r14b + 1,

        /// <summary>
        /// Identifies the 8-bit register SIL = RSI[7:0]
        /// </summary>
        sil = dh << 8,

        /// <summary>
        /// Identifies  the 8-bit register DIL = RDI[7:0]
        /// </summary>
        dil = bh << 8,

        /// <summary>
        /// Identifies the 8-bit register BPL = RBP[7:0]
        /// </summary>
        bpl = ch << 8,

        /// <summary>
        /// Identifies the 8-bit register SPL = RSP[7:0]
        /// </summary>
        spl = ah << 8


    }

}