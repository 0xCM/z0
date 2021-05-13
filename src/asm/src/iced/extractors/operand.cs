//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IceExtractors
    {
        /// <summary>
        /// Defines an instruction operand
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="src"></param>
        /// <param name="index"></param>
        [MethodImpl(Inline), Op]
        public static IceOperandInfo operand(MemoryAddress @base, in IceInstruction src, byte index)
        {
            var dst = new IceOperandInfo();
            dst.Index = index;
            dst.Kind = opkind(src, index);
            dst.Branch = IceOpTest.isBranch(dst.Kind) ? branch(@base, src, branch(src,index)) : default;
            dst.ImmInfo = imminfo(src, index);
            dst.Memory = IceOpTest.isMem(dst.Kind) ? meminfo(src,index) : default;
            dst.Register = IceOpTest.isRegister(dst.Kind) ? register(src,index) : default;
            return dst;
        }
    }
}