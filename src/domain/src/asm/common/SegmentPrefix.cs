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

    public readonly struct SegmentPrefix : INullity
    {
        public readonly Register Register;

        public bool IsEmpty 
            => Register == Register.None;

        public static bool test(Instruction inxs, int index)     
            => !from(inxs,index).IsEmpty;

        public static SegmentPrefix from(Instruction inxs, int index) 
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
        public SegmentPrefix(Register src)
        {
            Register = src;
        }        

        public static SegmentPrefix Empty 
            => new SegmentPrefix(Register.None);   

    }
}