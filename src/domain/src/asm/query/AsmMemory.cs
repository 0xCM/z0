//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;    

    partial struct AsmQuery : TSemanticQuery
    {
 
        public bool IsSegBase(OpKind src)
            => asm.testsegbase(src);

        public bool IsSegEs(OpKind src)            
            => src == OpKind.MemoryESDI
            || src == OpKind.MemoryESEDI
            || src == OpKind.MemoryESRDI;

        public bool IsMem64(OpKind src)
            => src == OpKind.Memory64;

        public bool IsMemDirect(OpKind src)
            => src == OpKind.Memory;         
        
        public bool IsMem(OpKind src)            
            => IsMemDirect(src) || IsMem64(src) || IsSegEs(src) || IsSegBase(src);

        public InstructionMemory InxsMemory(Instruction src, int index)
            => InstructionMemory.From(src,index);

        public bool HasInxsMemory(Instruction src, int index)
            => InstructionMemory.Has(src,index);
            
        public MemInfo MemInfo(Instruction src, int index)
        {            
            var k = OperandKind(src, index);        

            if(IsMem(k))
            {
                var isDirect = IsMemDirect(k);
                var isSegBase = IsSegBase(k);

                var info = new MemInfo();
                var sz = src.MemorySize;
                var memdirect = IsMemDirect(k) ? MemDirect.From(src) : MemDirect.Empty;
                var prefix = (isDirect || isSegBase) ? src.SegmentPrefix : Register.None;
                var segreg = (isDirect || isSegBase) ? src.MemorySegment : Register.None;
                var mem64 = IsMem64(k) ? src.MemoryAddress64 : 0;
                return asm.meminfo(segreg, prefix, memdirect, mem64, sz);
            }

            return default;
        } 
 
        /// <summary>
        /// Specifies the segmented identity of a specified memory size
        /// </summary>
        /// <param name="src">The source value</param>
        public SegmentedIdentity Identify(MemorySize src)
            => asm.identify(src);
    }
}