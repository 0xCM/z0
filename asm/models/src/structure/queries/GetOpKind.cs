//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    using static Seed;

	partial class ModelQueries
    {
		/// <summary>
		/// Gets an operand's kind if it exists (see <see cref="OpCount"/>)
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		public static OpKind GetOpKind(this Instruction src, int operand) {
			switch (operand) {
			case 0: return src.Op0Kind;
			case 1: return src.Op1Kind;
			case 2: return src.Op2Kind;
			case 3: return src.Op3Kind;
			case 4: return src.Op4Kind;
			default:
				throw new ArgumentException($"The operand index {operand} is out of range");
			}
		}
    }
}