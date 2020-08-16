//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm;
    
    using static Konst;
    using static Asm.OpKind;

    using W = NumericWidth;
      
    partial struct asm
    {
        [Op]
        public static ImmInfo immInfo(Instruction src, int index) 
        {                        
			switch (kind(src,index)) 
            {
                case Immediate8:			
                    return asm.imm((byte)src.Immediate8, true); 
                case Immediate8_2nd:		
                    return asm.imm((byte)src.Immediate8_2nd, true); 
                case Immediate16:		
                    return asm.imm((ushort)src.Immediate16, true); 
                case Immediate32:		
                    return asm.imm((uint)src.Immediate32, true); 
                case Immediate64:		
                    return asm.imm((ulong)src.Immediate64, true); 
                case Immediate8to16:		
                    return asm.imm((short)src.Immediate8to16, false, (W.W8, W.W16)); 
                case Immediate8to32:		
                    return asm.imm((int)src.Immediate8to32, false, (W.W8, W.W32)); 
                case Immediate8to64:		
                    return asm.imm((long)src.Immediate8to64, false, (W.W8, W.W64)); 
                case Immediate32to64:	
                    return asm.imm((int)src.Immediate32to64, false, (W.W32, W.W64)); 				
			}
            
            return ImmInfo.Empty;
		}        
    }
}