//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Reflection;

    using Z0.Asm;

    using static zfunc;

    partial class AsmExtend
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

		public static ulong GetImmediate(this Instruction src, int operand) {
			switch (src.GetOpKind(operand)) {
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
				throw new ArgumentException($"Op{operand} isn't an immediate operand", nameof(operand));
			}
		}

		/// <summary>
		/// Gets the operand's register value. Use this property if the operand has kind <see cref="OpKind.Register"/>
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		public static Register GetOpRegister(this Instruction src, int operand) {
			switch (operand) {
			case 0: return src.Op0Register;
			case 1: return src.Op1Register;
			case 2: return src.Op2Register;
			case 3: return src.Op3Register;
			case 4: return src.Op4Register;
			default:
				throw new ArgumentException($"The operand index {operand} is out of range");
			}
		}       
    }
}