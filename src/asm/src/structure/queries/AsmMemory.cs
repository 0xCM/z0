//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public class AsmMemory
    {
        /// <summary>
        /// Determines whether the classified operand is a segment of the form 
        /// seg:[di], seg:[edi], seg:[esi], seg:[rdi], seg:[rsi], seg:[si]
        /// Relevant instruction attributes include: MemorySize, MemorySegment, SegmentPrefix 
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool segbase(OpKind src)
            => src == OpKind.MemorySegDI
            || src == OpKind.MemorySegEDI
            || src == OpKind.MemorySegESI
            || src == OpKind.MemorySegRDI
            || src == OpKind.MemorySegRSI
            || src == OpKind.MemorySegSI;

        /// <summary>
        /// Determines whether the classified operand is an ES ("extra") memory segment.
        /// Possible choices include es:[di], es:[edi], es:[rdi]
        /// Relevant instruction attributes inlude: MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool es(OpKind src)            
            => src == OpKind.MemoryESDI
            || src == OpKind.MemoryESEDI
            || src == OpKind.MemoryESRDI;

        /// <summary>
        /// Determines whether the classified operand is a 64-bit memory offset. 
        /// Relevant instruction attributes include:
        /// MemoryAddress64, MemorySegment, SegmentPrefix, MemorySize
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool mem64(OpKind src)
            => src == OpKind.Memory64;

        /// <summary>
        /// Determines whether the classified operand is direct memory.
        /// Relevant instruction attributes include: 
        /// MemoryDisplSize, MemorySize, MemoryIndexScale, MemoryDisplacement, MemoryBase, 
        /// MemoryIndex, MemorySegment, SegmentPrefix
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool direct(OpKind src)
            => src == OpKind.Memory;         
        
        /// <summary>
        /// Determines whether the classified operand is some sort of memory
        /// </summary>
        /// <param name="src">The operand classifier</param>
        [MethodImpl(Inline)]
        public static bool any(OpKind src)            
            => direct(src) || mem64(src) || es(src) || segbase(src);


        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmMemInfo> describe(Instruction src, int index)
        {            
            var k = AsmInstruction.kind(src,index);            
            if(any(k))
            {
                var info = AsmMemInfo.Init(src.MemorySize, AsmFormat.render(src.MemorySize));
                info.Size = src.MemorySize;
                info.SizeFormat = AsmFormat.render(src.MemorySize);

                if(direct(k))
                {
                    info.BaseRegister = src.MemoryBase;
                    info.Displacement = src.MemoryDisplacement;
                    info.DisplacementSize = src.MemoryDisplSize;
                    info.IndexScale = src.MemoryIndexScale;
                }

                if(direct(k) || segbase(k))
                {
                    if(src.SegmentPrefix.IsSome())
                        info.SegmentPrefix = src.SegmentPrefix;
                    
                    info.SegmentRegister = src.MemorySegment;
                }

                if(mem64(k))
                    info.Address = src.MemoryAddress64;                

                return info;
            }

            return none<AsmMemInfo>();
        } 
    }
}