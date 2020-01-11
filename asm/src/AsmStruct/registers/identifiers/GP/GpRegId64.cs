//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Classifies 64-bit general purpose registers
    /// </summary>
    public enum GpRegId64 : uint
    {
        /// <summary>
        /// Identifies the 64-bit register RAX
        /// </summary>
        rax = 0,

        /// <summary>
        /// Identifies the 64-bit register RCX
        /// </summary>
        rcx = rax + 1,

        /// <summary>
        /// Identifies the 64-bit register RDX
        /// </summary>
        rdx = rcx + 1,

        /// <summary>
        /// Identifies the 64-bit register RBX
        /// </summary>
        rbx = rdx + 1,

        /// <summary>
        /// Identifies the 64-bit register RSP
        /// </summary>
        rsp = rbx + 1,

        /// <summary>
        /// Identifies the 64-bit register RBP
        /// </summary>
        rbp = rsp + 1,

        /// <summary>
        /// Identifies the 64-bit register RSI
        /// </summary>
        rsi = rbp + 1,

        /// <summary>
        /// Identifies the 64-bit register RDI
        /// </summary>
        rdi = rsi + 1,

        /// <summary>
        /// Identifies the 64-bitregister R8
        /// </summary>
        r8 = rdi + 1,

        /// <summary>
        /// Identifies the 64-bit register R9
        /// </summary>
        r9 = r8 + 1,
        
        /// <summary>
        /// Identifies the 64-bit register R10
        /// </summary>
        r10 = r9 + 1,

        /// <summary>
        /// Identifies the 64-bit register R11
        /// </summary>
        r11 = r10 + 1,

        /// <summary>
        /// Identifies the 64-bit register R12
        /// </summary>
        r12 = r11 + 1,

        /// <summary>
        /// Identifies the 64-bit register R13
        /// </summary>
        r13 = r12 + 1,

        /// <summary>
        /// Identifies the 64-bit register R14
        /// </summary>
        r14 = r13 + 1,

        /// <summary>
        /// Identifies the 64-bit register R15
        /// </summary>
        r15 = r14 + 1,
    
    }

}
