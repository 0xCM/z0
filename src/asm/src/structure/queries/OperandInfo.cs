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
 
	partial class ModelQueries
    {
        /// <summary>
        /// Extracts operand information from an instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        public static AsmOperandInfo[] SummarizeOperands(this Instruction src, ulong baseaddress)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = src.OperandInfo(j,baseaddress);
            return args;
        }

        public static AsmOperandInfo OperandInfo(this Instruction src, int index, ulong baseaddress)
            => AsmOperandInfo.Define(index, 
                src.GetOpKind(index),
                src.ImmInfo(index),
                src.MemoryInfo(index),
                src.RegisterInfo(index),
                src.BranchInfo(index,baseaddress)
                );
    }
}