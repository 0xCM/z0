//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static OpKind;

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

        public static InstructionMemory From(Instruction src, int index)
        {
            var dst = default(InstructionMemory);
            dst.MemoryBase = Z0.asm.membase(src,index);
            dst.MemoryIndex = Z0.asm.memidx(src,index);
            dst.MemorySize = Z0.asm.memsize(src,index);
            dst.MemoryIndexScale = Z0.asm.memscale(src,index);
            dst.MemDx = Z0.asm.memdx(Z0.asm.memdx(src,index), Z0.asm.memdxsize(src,index));
            dst.MemorySegment = Z0.asm.memseg(src,index);
            dst.SegmentPrefix = GetSegmentPrefix(src,index);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }

        public static bool Has(Instruction src, int index)
        {
            switch(Z0.asm.kind(src,index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                    return true;
                default:
                    return false;
            }
        }
        

        public bool IsEmpty 
            => CalcEmpty();

        bool CalcEmpty()
        {
            var empty = true;
            empty &= (MemoryBase == 0);
            empty &= (MemoryIndex == 0);
            empty &= (MemorySize == 0);
            empty &= (MemoryIndexScale.IsEmpty);
            empty &= (MemDx.IsEmpty);
            empty &= (MemorySegment == 0);
            empty &= (SegmentPrefix == 0);
            empty &= (!IsStackInstruction);
            empty &= (StackPointerIncrement == 0);            
            empty &= (!IsIPRelativeMemoryOperand);
            return empty;
        }

        static AsmQuery query 
            => AsmQuery.Direct;


        static Register GetMemorySegment(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                    return src.MemorySegment;
                default:
                    return Register.None;
            }
        }

        static Register GetSegmentPrefix(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                    return src.MemorySegment;
                default:
                    return Register.None;
            }
        }
    }
}