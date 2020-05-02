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

    partial struct AsmQuery : IAsmQuery
    {
        public int ImmSize(OpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return 8;
            else if(src == Immediate16 || src == Immediate8to16)
                return 16;
            else if(src == Immediate32 || src == Immediate8to32)
                return 32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return 64;
            else
                return 0;
        }

        public ulong ExtractImm(Instruction src, int index) 
        {
			switch (OperandKind(src,index)) {
			case OpKind.Immediate8:			return src.Immediate8;
			case OpKind.Immediate8_2nd:		return src.Immediate8_2nd;
			case OpKind.Immediate16:		return src.Immediate16;
			case OpKind.Immediate32:		return src.Immediate32;
			case OpKind.Immediate64:		return src.Immediate64;
			case OpKind.Immediate8to16:		return (ulong)src.Immediate8to16;
			case OpKind.Immediate8to32:		return (ulong)src.Immediate8to32;
			case OpKind.Immediate8to64:		return (ulong)src.Immediate8to64;
			case OpKind.Immediate32to64:	return (ulong)src.Immediate32to64;
			default:
				throw new ArgumentException($"Op{index} isn't an immediate operand", nameof(index));
			}
		}

        [MethodImpl(Inline)]
        public bool IsSignedImm(OpKind src)
            => src == OpKind.Immediate8to16  
            || src == OpKind.Immediate8to32  
            || src == OpKind.Immediate8to64  
            || src == OpKind.Immediate32to64;

        [MethodImpl(Inline)]
        public bool IsDirectImm(OpKind src)
            => src == OpKind.Immediate8
            || src == OpKind.Immediate16
            || src == OpKind.Immediate32
            || src == OpKind.Immediate64;

        [MethodImpl(Inline)]
        public bool IsSpecialImm(OpKind src)
            => src == OpKind.Immediate8_2nd;
        
        [MethodImpl(Inline)]
        public bool IsImmOperand(OpKind src)
            => IsSignedImm(src) || IsDirectImm(src) || IsSpecialImm(src);

        public AsmImmInfo ImmInfo(Instruction src, int index)
        {
            var empty = AsmImmInfo.Empty;
            var k =  OperandKind(src,index);
            if(!IsImmOperand(k))
                return empty;

            int sz = ImmSize(k);
            if(sz == 0)
                return empty;

            var signed =  IsSignedImm(k);
            var imm = ExtractImm(src,index);
            switch(sz)
            {
                case Pow2.T03:
                    return AsmImmInfo.Define(sz, imm);
                case Pow2.T04:
                    if(signed)
                        return AsmImmInfo.Define(sz, (long)imm);
                    else 
                        return AsmImmInfo.Define(sz, imm);
                case Pow2.T05:
                    if(signed)
                        return AsmImmInfo.Define(sz, (long)imm);
                    else 
                        return AsmImmInfo.Define(sz, imm);
                case Pow2.T06:
                    if(signed)
                        return AsmImmInfo.Define(sz, (long)imm);
                    else 
                        return AsmImmInfo.Define(sz, imm);
                default:
                    return empty;
            }
        }
    }
}