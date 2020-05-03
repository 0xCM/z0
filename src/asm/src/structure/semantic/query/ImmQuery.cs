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

    using W = NumericWidth;

    partial struct AsmQuery : IAsmQuery
    {
        public NumericWidth ImmWidth(OpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return W.W8;
            else if(src == Immediate16 || src == Immediate8to16)
                return W.W16;
            else if(src == Immediate32 || src == Immediate8to32)
                return W.W32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return W.W64;
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

        public AsmImmInfo DescribeImm(Instruction src, int index) 
        {                        
			switch (OperandKind(src,index)) 
            {
                case OpKind.Immediate8:			
                    return AsmImmInfo.Define((byte)src.Immediate8,true); 
                case OpKind.Immediate8_2nd:		
                    return AsmImmInfo.Define((byte)src.Immediate8,true); 
                case OpKind.Immediate16:		
                    return AsmImmInfo.Define((ushort)src.Immediate8,true); 
                case OpKind.Immediate32:		
                    return AsmImmInfo.Define((uint)src.Immediate8,true); 
                case OpKind.Immediate64:		
                    return AsmImmInfo.Define((ulong)src.Immediate8,true); 
                case OpKind.Immediate8to16:		
                    return AsmImmInfo.Define((short)src.Immediate8,false,(W.W8,W.W16)); 
                case OpKind.Immediate8to32:		
                    return AsmImmInfo.Define((int)src.Immediate8,false,(W.W8,W.W32)); 
                case OpKind.Immediate8to64:		
                    return AsmImmInfo.Define((long)src.Immediate8,false,(W.W8,W.W64)); 
                case OpKind.Immediate32to64:	
                    return AsmImmInfo.Define((int)src.Immediate8,false,(W.W32,W.W64)); 				
			}
            
            return AsmImmInfo.Empty;

		}

        
        // public AsmImmInfo ImmInfo(Instruction src, int index)
        // {
        //     var empty = AsmImmInfo.Empty;
        //     var k =  OperandKind(src,index);
        //     if(!IsImmOperand(k))
        //         return empty;

        //     var sz = ImmWidth(k);
        //     if(sz == 0)
        //         return empty;

        //     var signed =  IsSignedImm(k);
        //     var imm = ExtractImm(src,index);
        //     var direct = IsDirectImm(k);
        //     switch(sz)
        //     {
        //         case W.W8:
        //             return AsmImmInfo.Define((byte)imm, direct);
        //         case W.W16:
        //             if(signed)
        //                 return AsmImmInfo.Define((short)imm, direct);
        //             else 
        //                 return AsmImmInfo.Define( (ushort)imm, direct);
        //         case W.W32:
        //             if(signed)
        //                 return AsmImmInfo.Define((int)imm, direct);
        //             else 
        //                 return AsmImmInfo.Define((uint)imm, direct);
        //         case W.W64:
        //             if(signed)
        //                 return AsmImmInfo.Define((long)imm, direct);
        //             else 
        //                 return AsmImmInfo.Define(imm, direct);
        //         default:
        //             return empty;
        //     }
        // }
    }
}