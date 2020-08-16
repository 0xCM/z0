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
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="@base">The base address</param>
        public static AsmOperandInfo[] operands(MemoryAddress @base, in Instruction src)
        {
            var args = new AsmOperandInfo[src.OpCount];
            for(byte j=0; j< src.OpCount; j++)
                args[j] = operand(@base, src, j);
            return args;
        }
    }
}