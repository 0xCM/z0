//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct asm
    {
        /// <summary>
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="fx">The source instruction</param>
        /// <param name="@base">The base address</param>
        [MethodImpl(Inline), Op]
        public static IceOperandInfo[] operands(MemoryAddress @base, in IceInstruction fx)
        {
            var count = fx.OpCount;
            var buffer = alloc<IceOperandInfo>(count);
            var dst = span(buffer);
            for(byte j=0; j<count; j++)
                seek(dst, j) = operand(@base, fx, j);
            return buffer;
        }
    }
}