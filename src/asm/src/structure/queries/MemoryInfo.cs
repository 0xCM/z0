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
 
	partial class ModelQueries
    {
        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmMemInfo> MemoryInfo(this Instruction src, int index)
        {            
            var kind = src.GetOpKind(index);
            
            if(kind.IsMemory())
            {
                var info = AsmMemInfo.Init(src.MemorySize, src.MemorySize.Format());
                info.Size = src.MemorySize;
                info.SizeFormat = src.MemorySize.Format();

                if(kind.IsDirectMemory())
                {
                    info.BaseRegister = src.MemoryBase;
                    info.Displacement = src.MemoryDisplacement;
                    info.DisplacementSize = src.MemoryDisplSize;
                    info.IndexScale = src.MemoryIndexScale;
                }

                if(kind.IsDirectMemory() || kind.IsBaseSegment())
                {
                    if(src.SegmentPrefix.IsSome())
                        info.SegmentPrefix = src.SegmentPrefix;
                    
                    info.SegmentRegister = src.MemorySegment;
                }

                if(kind.IsMem64())
                    info.Address = src.MemoryAddress64;                

                return info;
            }

            return none<AsmMemInfo>();
        } 
    }
}