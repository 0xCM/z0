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
        /// Extracts register information, should it exist, from an index-identified register operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline), Op]
		public static Register register(in Instruction src, byte index) 
        {
			switch (index) 
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