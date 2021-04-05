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
        /// <param name="fx"></param>
        /// <param name="index"></param>
        [MethodImpl(Inline), Op]
        public static IceOperandInfo operand(MemoryAddress @base, in IceInstruction fx, byte index)
        {
            var dst = new IceOperandInfo();
            dst.Index = index;
            dst.Kind = opkind(fx, index);
            dst.Branch = IceOpTest.isBranch(dst.Kind) ? branch(@base, fx, branch(fx,index)) : default;
            dst.ImmInfo = imminfo(fx, index);
            dst.Memory = IceOpTest.isMem(dst.Kind) ? meminfo(fx,index) : default;
            dst.Register = IceOpTest.isRegister(dst.Kind) ? register(fx,index) : default;
            return dst;
        }
    }
}