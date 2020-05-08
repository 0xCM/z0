//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static OpKind;

    public struct AsmInxsMemory : IAsmInxsMemory
    {
        public string Render()
            => SemanticRender.Service.RenderAspects<IAsmInxsMemory>(this);

        public static AsmInxsMemory From(Instruction src, int index)
        {
            var dst = default(AsmInxsMemory);
            dst.MemoryBase = GetMemoryBase(src,index);
            dst.MemoryIndex = GetMemoryIndex(src,index);
            dst.MemorySize = GetMemorySize(src,index);
            dst.MemoryIndexScale = GetMemoryIndexScale(src,index);
            dst.MemoryDisplacement = GetMemoryDisplacement(src,index);
            dst.MemoryDisplSize = GetMemoryDisplSize(src,index);
            dst.MemorySegment = GetMemorySegment(src,index);
            dst.SegmentPrefix = GetSegmentPrefix(src,index);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }

        public static bool Has(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
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
        
        public Register MemoryBase {get; private set;}

        public Register MemoryIndex {get; private set;}

        public MemorySize MemorySize {get; private set;}

        public AsmMemScale MemoryIndexScale {get; private set;}

        public uint MemoryDisplacement {get; private set;}

        public int MemoryDisplSize {get; private set;}

        public Register MemorySegment {get; private set;}

        public Register SegmentPrefix {get; private set;}

        public bool IsStackInstruction {get; private set;}

        public int StackPointerIncrement {get; private set;}

        public bool IsIPRelativeMemoryOperand {get; private set;}

        public ulong IPRelativeMemoryAddress {get; private set;}

        public bool IsEmpty => CalcEmpty();

        bool CalcEmpty()
        {
            var empty = true;
            empty &= (MemoryBase == 0);
            empty &= (MemoryIndex == 0);
            empty &= (MemorySize == 0);
            empty &= (MemoryIndexScale.IsEmpty);
            empty &= (MemoryDisplacement == 0);
            empty &= (MemoryDisplSize == 0);
            empty &= (MemorySegment == 0);
            empty &= (SegmentPrefix == 0);
            empty &= (!IsStackInstruction);
            empty &= (StackPointerIncrement == 0);            
            empty &= (!IsIPRelativeMemoryOperand);
            return empty;
        }

        static AsmQuery query => AsmQuery.Direct;

        static Register GetMemoryBase(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                    return src.MemoryBase;
                default:
                    return Register.None;
            }
        }

        static Register GetMemoryIndex(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                    return src.MemoryBase;
                default:
                    return Register.None;
            }
        }

        static MemorySize GetMemorySize(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                    return src.MemorySize;
                default:
                    return MemorySize.Unknown;
            }
        }

        static AsmMemScale GetMemoryIndexScale(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                    return src.MemoryIndexScale;
                default:
                    return AsmMemScale.Empty;
            }
        }

        static uint GetMemoryDisplacement(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                    return src.MemoryDisplacement;
                default:
                    return 0;
            }
        }

        static int GetMemoryDisplSize(Instruction src, int index)
        {
            switch(query.OperandKind(src,index))
            {
                case Memory:
                    return src.MemoryDisplSize;
                default:
                    return 0;
            }
        }

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