//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        /// <summary>
        /// Defines an instruction operand
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="fx"></param>
        /// <param name="index"></param>
        [MethodImpl(Inline), Op]
        public static AsmOperandInfo operand(MemoryAddress @base, in IceInstruction fx, byte index)
        {
            var dst = new AsmOperandInfo();
            dst.Index = index;
            dst.Kind = kind(fx, index);
            dst.Branch = AsmTest.isBranch(dst.Kind) ? branch(@base, fx, branch(fx,index)) : default;
            return dst;
        }
    }
}