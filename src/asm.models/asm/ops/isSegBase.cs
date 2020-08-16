//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
        
    using static Konst;
    using static Asm.OpKind;

    partial struct asm
    {
        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline), Op]
        public static bool isSegBase(OpKind src)
            => src == MemorySegDI
            || src == MemorySegEDI
            || src == MemorySegESI
            || src == MemorySegRDI
            || src == MemorySegRSI
            || src == MemorySegSI;
    }
}