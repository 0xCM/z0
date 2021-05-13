//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct IceExtractors
    {
        /// <summary>
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="instruction">The source instruction</param>
        /// <param name="@base">The base address</param>
        [Op]
        public static IceOperandInfo[] operands(MemoryAddress @base, in IceInstruction instruction)
        {
            var count = instruction.OpCount;
            var buffer = alloc<IceOperandInfo>(count);
            var dst = span(buffer);
            for(byte j=0; j<count; j++)
                seek(dst, j) = operand(@base, instruction, j);
            return buffer;
        }
    }
}