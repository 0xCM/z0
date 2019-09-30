//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Classifies 32-bit general purpose registers
    /// </summary>
    public enum GpRegId32 : uint
    {
        /// <summary>
        /// Identifies the 32-bit register EAX = RAX[31:0]
        /// </summary>
        eax = 0,  
        
        /// <summary>
        /// Identifies the 32-bit register ECX = RCX[31:0]
        /// </summary>
        ecx = eax + 1,

        /// <summary>
        /// Identifies the 32-bit register EDX = RDX[31:0]
        /// </summary>
        edx = ecx + 1,

        /// <summary>
        /// Identifies the 32-bit register RBX = RBX[31:0]
        /// </summary>
        ebx = edx + 1,

        /// <summary>
        /// Identifies the 32-bit register ESP = RSP[31:0]
        /// </summary>
        esp = ebx + 1,

        /// <summary>
        /// Identifies the 32-bit register EBP = RBP[31:0]
        /// </summary>
        ebp = esp + 1,

        /// <summary>
        /// Identifies the 32-bit register ESI = RSI[31:0]
        /// </summary>
        esi = ebp + 1,

        /// <summary>
        /// Identifies the 32-bit register EDI = RDI[31:0]
        /// </summary>
        edi = esi + 1,

        /// <summary>
        /// Identifies the 32-bit register R8D = R8[31:0]
        /// </summary>
        r8d = edi + 1,

        /// <summary>
        /// Identifies the 32-bit register R9d = R9[31:0]
        /// </summary>
        r9d = r8d + 1,

        /// <summary>
        /// Identifies the 32-bit register R10d = R10[31:0]
        /// </summary>
        r10d = r9d + 1,

        /// <summary>
        /// Identifies the 32-bit register R11d = R11[31:0]
        /// </summary>
        r11d =  r10d + 1,

        /// <summary>
        /// Identifies the 32-bit register R12d = R12[31:0]
        /// </summary>
        r12d =  r11d + 1,

        /// <summary>
        /// Identifies the 32-bit register R13d = R13[31:0]
        /// </summary>
        r13d =  r12d + 1,

        /// <summary>
        /// Identifies the 32-bit register R14d = R14[31:0]
        /// </summary>
        r14d =  r13d + 1,

        /// <summary>
        /// Identifies the 32-bit register R15d = R15[31:0]
        /// </summary>
        r15d =  r14d + 1,

    }
}
