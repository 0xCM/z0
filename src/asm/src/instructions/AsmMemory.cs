//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AsmMemory
    {
        public RegisterKind MemoryBase;

        public RegisterKind MemoryIndex;

        public MemorySize MemorySize;

        public MemScale MemoryIndexScale;

        public MemDx MemDx;

        public RegisterKind MemorySegment;

        public RegisterKind SegmentPrefix;

        public bool IsStackInstruction;

        public int StackPointerIncrement;

        public bool IsIPRelativeMemoryOperand;

        public MemoryAddress IPRelativeMemoryAddress;    }

}