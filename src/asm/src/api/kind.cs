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

    partial struct asm
    {
 		/// <summary>
		/// Gets an operand's kind if it exists
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
        [MethodImpl(Inline), Op]
		public static OpKind kind(in Instruction src, byte operand)
        {
            if(operand == 0)
                return src.Op0Kind;
            else if(operand == 1)
                return src.Op1Kind;
            else if(operand == 2)
                return src.Op2Kind;
            else if(operand == 3)
                return src.Op3Kind;
            else if(operand == 4)
                return src.Op4Kind;
            else
                return 0;

			// switch (operand) {
			// case 0: return src.Op0Kind;
			// case 1: return src.Op1Kind;
			// case 2: return src.Op2Kind;
			// case 3: return src.Op3Kind;
			// case 4: return src.Op4Kind;
			// default:
			// 	return 0;
			// }
		}

    }
}