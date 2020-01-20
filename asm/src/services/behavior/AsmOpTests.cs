//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

	using Iced.Intel;
    
    using AsmOpKind = Iced.Intel.OpKind;
    
    using static Iced.Intel.OpKind;
    using static zfunc;
    
    static class AsmOpTests
    {        
        /// <summary>
        /// Determines whether the classified operand is a 16-bit, 32-bit or 64-bit near branch
        /// Assessed respectively via the NearBranch16, NearBranch32 and NearBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsNearBranch(this AsmOpKind src)        
            => src == AsmOpKind.NearBranch16
            || src == AsmOpKind.NearBranch32
            || src == AsmOpKind.NearBranch64;

        /// <summary>
        /// Determines whether the classified operand is a 32-bit or 64-bit far branch
        /// Assessed respectively via the FarBranch32 and FarBranch64 instruction attributes
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsFarBranch(this AsmOpKind src)        
            => src == AsmOpKind.FarBranch16
            || src == AsmOpKind.FarBranch32;

        /// <summary>
        /// Determines whether a classified operand is associated with a branching instruction
        /// </summary>
        /// <param name="src">The operand classification</param>
        public static bool IsBranch(this AsmOpKind src)
            => src.IsFarBranch() || src.IsNearBranch();

        /// <summary>
        /// Determines whether the classified operand is an 8-bit immediate
        /// used by the enter, extrq, or insertq instructions
        /// Accessed via the instruction attribute Immediate8_2nd
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSpecialImmediate8(this AsmOpKind src)
            => src == AsmOpKind.Immediate8_2nd;
        
        /// <summary>
        /// Determines whether the classified operand a sign-extended immediate which may include:
        /// An 8-bit value sign extended to 16 bits, accessed via the Immediate8to16 instruction attribute
        /// An 8-bit value sign extended to 32 bits, accessed via Immediate8to32 instruction attribute
        /// An 8-bit value sign extended to 64 bits, accessed via the Immediate8to64 instruction attribute
        /// A 32-bit value sign extended to 64 bits, accessed via the Immediate32to64 instruction attribute
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsSignExtendedImmediate(this AsmOpKind src)
            => src == AsmOpKind.Immediate8to16  
            || src == AsmOpKind.Immediate8to32  
            || src == AsmOpKind.Immediate8to64  
            || src == AsmOpKind.Immediate32to64 
             ;

        /// <summary>
        /// Determines whether the classified operand is an 8-bit, 16-bit, 32-bit or 64-bit constant
        /// which are accessed respectively through the Immediate8, Immediate16, Immediate32, and Immediate64
        /// instruction attributes
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectImmediate(this AsmOpKind src)
            => src == AsmOpKind.Immediate8
            || src == AsmOpKind.Immediate16
            || src == AsmOpKind.Immediate32
            || src == AsmOpKind.Immediate64
            ;

        /// <summary>
        /// Determines whether the classified operand is an immediate of some sort
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsImmediate(this AsmOpKind src)
            => src.IsSignExtendedImmediate() || src.IsDirectImmediate() || src.IsSpecialImmediate8();

        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsBaseSegment(this AsmOpKind src)
            => src == AsmOpKind.MemorySegDI
            || src == AsmOpKind.MemorySegEDI
            || src == AsmOpKind.MemorySegESI
            || src == AsmOpKind.MemorySegRDI
            || src == AsmOpKind.MemorySegRSI
            || src == AsmOpKind.MemorySegSI
            ;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsEsSegment(this AsmOpKind src)            
            => src == AsmOpKind.MemoryESDI
            || src == AsmOpKind.MemoryESEDI
            || src == AsmOpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMem64(this AsmOpKind src)
            =>  src == AsmOpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsDirectMemory(this AsmOpKind src)
            => src == AsmOpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsMemory(this AsmOpKind src)            
            => src.IsDirectMemory() || src.IsMem64() || src.IsEsSegment() || src.IsBaseSegment();

        /// <summary>
        /// Determines whether the classified operand is a register
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static bool IsRegister(this AsmOpKind src)
            => src == AsmOpKind.Register;  
    }
}