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

    [ApiHost]
    public readonly struct AsmOperands
    {
        /// <summary>
        /// Returns the <see cref='OpKind'/> classifier for an index-identified operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline), Op]
		public static OpKind kind(Instruction src, byte index) 
        {
			switch (index) {
			case 0: return src.Op0Kind;
			case 1: return src.Op1Kind;
			case 2: return src.Op2Kind;
			case 3: return src.Op3Kind;
			case 4: return src.Op4Kind;
			default:
				return 0;
			}
		}    

        [MethodImpl(Inline), Op]
		public static OpKind kind(Instruction src, int operand) 
			=> kind(src, (byte)operand);        
    }
}