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

    using W = NumericWidth;

    partial struct AsmQuery : ISemanticQuery
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

        [MethodImpl(Inline), Op]
        public bool IsSignedImm(OpKind src)
            => src == OpKind.Immediate8to16  
            || src == OpKind.Immediate8to32  
            || src == OpKind.Immediate8to64  
            || src == OpKind.Immediate32to64;

        [MethodImpl(Inline), Op]
        public bool IsDirectImm(OpKind src)
            => src == OpKind.Immediate8
            || src == OpKind.Immediate16
            || src == OpKind.Immediate32
            || src == OpKind.Immediate64;

        [MethodImpl(Inline), Op]
        public bool IsSpecialImm(OpKind src)
            => src == OpKind.Immediate8_2nd;

        [MethodImpl(Inline), Op]
        public bool IsImm(OpKind src)
            => IsSignedImm(src) || IsDirectImm(src) || IsSpecialImm(src);

        public AsmImmInfo ImmInfo(Instruction src, int index) 
        {                        
			switch (OperandKind(src,index)) 
            {
                case OpKind.Immediate8:			
                    return AsmImmInfo.Define((byte)src.Immediate8, true); 
                case OpKind.Immediate8_2nd:		
                    return AsmImmInfo.Define((byte)src.Immediate8_2nd, true); 
                case OpKind.Immediate16:		
                    return AsmImmInfo.Define((ushort)src.Immediate16, true); 
                case OpKind.Immediate32:		
                    return AsmImmInfo.Define((uint)src.Immediate32, true); 
                case OpKind.Immediate64:		
                    return AsmImmInfo.Define((ulong)src.Immediate64, true); 
                case OpKind.Immediate8to16:		
                    return AsmImmInfo.Define((short)src.Immediate8to16, false, (W.W8, W.W16)); 
                case OpKind.Immediate8to32:		
                    return AsmImmInfo.Define((int)src.Immediate8to32, false, (W.W8, W.W32)); 
                case OpKind.Immediate8to64:		
                    return AsmImmInfo.Define((long)src.Immediate8to64, false, (W.W8, W.W64)); 
                case OpKind.Immediate32to64:	
                    return AsmImmInfo.Define((int)src.Immediate32to64, false, (W.W32, W.W64)); 				
			}
            
            return AsmImmInfo.Empty;
		}        
    }
}