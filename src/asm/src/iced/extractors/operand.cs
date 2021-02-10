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
        /// Defines an instruction operand
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="fx"></param>
        /// <param name="index"></param>
        [MethodImpl(Inline), Op]
        public static IceOperandInfo operand(MemoryAddress @base, in IceInstruction fx, byte index)
        {
            var dst = new IceOperandInfo();
            dst.Index = index;
            dst.Kind = opkind(fx, index);
            dst.Branch = IceOpTest.isBranch(dst.Kind) ? branch(@base, fx, branch(fx,index)) : default;
            return dst;
        }

        /// <summary>
        /// Extracts operand instruction data
        /// </summary>
        /// <param name="fx">The source instruction</param>
        /// <param name="@base">The base address</param>
        [Op]
        static IceOperandInfo[] operands(MemoryAddress @base, in IceInstruction fx)
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