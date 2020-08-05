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
   
    partial struct asm
    {
        [Op]
        public static ulong immval(Instruction src, int index) 
        {
			return kind(src, index) switch
            {
			    Immediate8 => src.Immediate8,
			    Immediate8_2nd => src.Immediate8_2nd,
			    Immediate16 => src.Immediate16,
			    Immediate32 => src.Immediate32, 
                Immediate64 => src.Immediate64,
			    Immediate8to16 => (ulong)src.Immediate8to16,
			    Immediate8to32 => (ulong)src.Immediate8to32,
			    Immediate8to64 => (ulong)src.Immediate8to64,
			    Immediate32to64 => (ulong)src.Immediate32to64,
			    _ => throw new ArgumentException($"Op{index} isn't an immediate operand", nameof(index))
			};
		}
    }
}