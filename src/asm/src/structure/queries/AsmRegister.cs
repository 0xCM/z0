//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public class AsmRegister
    {
        [MethodImpl(Inline)]
        public static bool test(OpKind src)
            => src == OpKind.Register;  

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmRegisterInfo> describe(Instruction src, int index)
            => test(AsmInstruction.kind(src,index)) 
              ? new AsmRegisterInfo(AsmRegister.extract(src,index))
              : none<AsmRegisterInfo>();

    	/// <summary>
		/// Gets the operand's register value. Use this property if the operand has kind <see cref="OpKind.Register"/>
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		public static Register extract(Instruction src, int operand) {
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