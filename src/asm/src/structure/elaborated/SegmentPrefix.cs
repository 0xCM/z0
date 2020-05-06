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

    public readonly struct SegmentPrefix : INullaryKnown
    {
        public Register Register {get;}

        public bool IsEmpty 
            => Register == Register.None;

        public static SegmentPrefix Empty => new SegmentPrefix(Register.None);   

        public static bool Test(Instruction inxs, int index)     
            => !From(inxs,index).IsEmpty;

        public static SegmentPrefix From(Instruction inxs, int index) 
        {
            var kind = AsmQuery.Direct.OperandKind(inxs, index);
            switch(kind)
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                    return new SegmentPrefix(inxs.MemorySegment);
            }
            return Empty;
        }

        [MethodImpl(Inline)]
        SegmentPrefix(Register src)
        {
            Register = src;
        }        
    }
}