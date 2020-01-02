//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Classifies 16-bit general purpose registers
    /// </summary>
    public enum GpRegId16 : uint
    {        
        /// <summary>
        /// Identifies the 16-bit register AX = EAX[15:0] = RAX[15:0] 
        /// </summary>
        ax =  0,  

        /// <summary>
        /// Identifies the 16-bit register CX = ECX[15:0] = RCX[15:0] 
        /// </summary>
        cx = ax + 1,

        /// <summary>
        /// Identifies the 16-bit register DX = EDX[15:0] = RDX[15:0]
        /// </summary>
        dx = cx + 1,

        /// <summary>
        /// Identifies the 16-bit register BX = RBX[15:0] or EBX[15:0]
        /// </summary>
        bx = dx + 1,

        /// <summary>
        /// Identifies the 16-bit register SP = ESP[15:0] = RSP[15:0]
        /// </summary>
        sp = bx + 1,

        /// <summary>
        /// Identifies the 16-bit register BP = EBP[15:0] = RBP[15:0]
        /// </summary>
        bp = sp + 1,

        /// <summary>
        /// Identifies the 16-bit register SI = ESI[15:0] = RSI[15:0]
        /// </summary>
        si  = bp + 1,

        /// <summary>
        /// Identifies the 16-bit register DI = EDI[15:0] = RDI[15:0]
        /// </summary>
        di = si + 1,

        /// <summary>
        /// Identifies the 16-bit register R8w = R8d[15:0] = R8[15:0]
        /// </summary>
        r8w = di + 1,

        /// <summary>
        /// Identifies the 16-bit register R9w = R9d[15:0] = R9[15:0]
        /// </summary>
        r9w = r8w + 1,

        /// <summary>
        /// Identifies the 16-bit register R10w = R10d[15:0] = R10[15:0]
        /// </summary>
        r10w = r9w + 1,

        /// <summary>
        /// Identifies the 16-bit register R11w = R11d[15:0] = R11[15:0]
        /// </summary>
        r11w = r10w + 1,

        /// <summary>
        /// Identifies the 16-bit register R11w = R12d[15:0] = R12[15:0]
        /// </summary>
        r12w = r11w + 1,

        /// <summary>
        /// Identifies the 16-bit register R13w = R13d[15:0] = R13[15:0]
        /// </summary>
        r13w = r12w + 1,

        /// <summary>
        /// Identifies the 16-bit register R14w = R14d[15:0] = R14[15:0]
        /// </summary>
        r14w = r13w + 1,
 
        /// <summary>
        /// Identifies the 16-bit register R15w = R15d[15:0] = R15[15:0]
        /// </summary>
        r15w = r14w + 1
    }

}