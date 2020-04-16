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

    using static OpKind;

	partial class ModelQueries
    {
        /// <summary>
        /// Determines the size of a classified immediate operand, if applicable; otherwise, returns 0
        /// </summary>
        /// <param name="src">The operand classifier</param>
        public static int ImmediateSize(this OpKind src)
        {
            if(src == Immediate8 || src == Immediate8_2nd)
                return 8;
            else if(src == Immediate16 || src == Immediate8to16)
                return 16;
            else if(src == Immediate32 || src == Immediate8to32)
                return 32;
            else if(src == Immediate64 || src == Immediate8to64 || src == Immediate32to64)
                return 64;
            else
                return 0;
        }

        /// <summary>
        /// Extracts immediate information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        public static Option<AsmImmInfo> ImmInfo(this Instruction src, int index)
        {
            var kind = src.GetOpKind(index);
            if(!kind.IsImmediate())
                return none<AsmImmInfo>();

            int size = kind.ImmediateSize();
            if(size == 0)
                return none<AsmImmInfo>();

            var signed = kind.IsSignExtendedImmediate();
            var imm = src.GetImmediate(index);
            switch(size)
            {
                case Pow2.T03:
                    return AsmImmInfo.Define(size, imm);
                case Pow2.T04:
                    if(signed)
                        return AsmImmInfo.Define(size, (long)imm);
                    else 
                        return AsmImmInfo.Define(size, imm);
                case Pow2.T05:
                    if(signed)
                        return AsmImmInfo.Define(size, (long)imm);
                    else 
                        return AsmImmInfo.Define(size, imm);
                case Pow2.T06:
                    if(signed)
                        return AsmImmInfo.Define(size, (long)imm);
                    else 
                        return AsmImmInfo.Define(size, imm);
                default:
                    return none<AsmImmInfo>();
            }
        }
    }
}