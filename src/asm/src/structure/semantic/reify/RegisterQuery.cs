//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial struct AsmQuery : IAsmQuery
    {
        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source operand kind</param>
        [MethodImpl(Inline)]
        public bool IsRegisterOperand(OpKind src)
            => src == OpKind.Register;  

        /// <summary>
        /// Extracts register information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline)]
        public AsmRegisterInfo RegisterInfo(Instruction src, int index)
            => IsRegisterOperand(OperandKind(src,index)) 
              ? new AsmRegisterInfo(OperandRegister(src,index)) 
              : AsmRegisterInfo.Empty;

    	/// <summary>
		/// Gets the operand's register value. Use this property if the operand has kind <see cref="OpKind.Register"/>
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		public Register OperandRegister(Instruction src, int operand) 
        {
			switch (operand) 
            {
                case 0: return src.Op0Register;
                case 1: return src.Op1Register;
                case 2: return src.Op2Register;
                case 3: return src.Op3Register;
                case 4: return src.Op4Register;
                default: return Register.None;				
			}
		}       
    }
}