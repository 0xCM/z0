//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    [Record(TableId)]
    public struct IceInstructionMemoryRecord : IRecord<IceInstructionMemoryRecord>
    {
        public const string TableId = "asm.fx-memory";

        public IceRegister MemoryBase;

        public IceRegister MemoryIndex;

        public IceMemorySize MemorySize;

        public MemoryScale MemoryIndexScale;

        public AsmDisplacement MemDx;

        public IceRegister MemorySegment;

        public IceRegister SegmentPrefix;

        public bool IsStackInstruction;

        public int StackPointerIncrement;

        public bool IsIPRelativeMemoryOperand;

        public MemoryAddress IPRelativeMemoryAddress;
   }
}