//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmQuery : TSemanticQuery
    {
        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source operand kind</param>
        public bool IsRegister(OpKind src)
            => src == OpKind.Register;  
            
    	/// <summary>
		/// Gets the operand's register value. Use this property if the operand has kind <see cref="OpKind.Register"/>
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
		public Register RegisterInfo(Instruction src, int operand) 
            => asm.register(src,(byte)operand);
    }
}