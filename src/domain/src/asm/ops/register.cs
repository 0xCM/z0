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
		/// Gets the operand's register value. Use this property if the operand has kind <see cref="OpKind.Register"/>
		/// </summary>
		/// <param name="operand">Operand number, 0-4</param>
        [MethodImpl(Inline), Op]
		public static Register register(in Instruction src, byte operand) 
        {
			switch (operand) 
            {
                case 0: return src.Op0Register;
                case 1: return src.Op1Register;
                case 2: return src.Op2Register;
                case 3: return src.Op3Register;
                case 4: return src.Op4Register;
			}
            return 0;
		}       

        /// <summary>
        /// Gets the register value of a naturally-identified operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="n">The operand selector</param>
        [MethodImpl(Inline), Op]
		public Register register(in Instruction src, N0 n) 
            => src.Op0Register;

        /// <summary>
        /// Gets the register value of a naturally-identified operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="n">The operand selector</param>
        [MethodImpl(Inline), Op]
		public Register register(in Instruction src, N1 n) 
            => src.Op1Register;

        /// <summary>
        /// Gets the register value of a naturally-identified operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="n">The operand selector</param>
        [MethodImpl(Inline), Op]
		public Register register(in Instruction src, N2 n) 
            => src.Op2Register;

        /// <summary>
        /// Gets the register value of a naturally-identified operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="n">The operand selector</param>
        [MethodImpl(Inline), Op]
		public Register register(in Instruction src, N3 n) 
            => src.Op3Register;

        /// <summary>
        /// Gets the register value of a naturally-identified operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="n">The operand selector</param>
        [MethodImpl(Inline), Op]
		public Register register(in Instruction src, N4 n) 
            => src.Op4Register;
    }
}