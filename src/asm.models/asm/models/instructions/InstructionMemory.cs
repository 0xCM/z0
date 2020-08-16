//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Z0.asm;

    public struct InstructionMemory
    {
        public Register MemoryBase;

        public Register MemoryIndex;

        public MemorySize MemorySize;

        public MemScale MemoryIndexScale;

        public MemDx MemDx;

        public Register MemorySegment;

        public Register SegmentPrefix;

        public bool IsStackInstruction;

        public int StackPointerIncrement;

        public bool IsIPRelativeMemoryOperand;

        public MemoryAddress IPRelativeMemoryAddress;

        public string AspectRender
            => SemanticRender.Service.RenderAspects<IInstructionMemory>(this);

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => api.empty(this);
        }
   }
}