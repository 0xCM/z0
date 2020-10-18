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

    public struct AsmFxMemory
    {
        public IceRegister MemoryBase;

        public IceRegister MemoryIndex;

        public MemorySize MemorySize;

        public MemScale MemoryIndexScale;

        public MemDx MemDx;

        public IceRegister MemorySegment;

        public IceRegister SegmentPrefix;

        public bool IsStackInstruction;

        public int StackPointerIncrement;

        public bool IsIPRelativeMemoryOperand;

        public MemoryAddress IPRelativeMemoryAddress;
   }
}