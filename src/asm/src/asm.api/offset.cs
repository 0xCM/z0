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

        [MethodImpl(Inline), Op]
        public static AsmScaledOffset offset(ulong @base, ushort offset, byte scale)
            => new AsmScaledOffset(@base, offset, scale);

        /// <summary>
        /// Defines an IP offset relative to a specified base address, instruction size and target address
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The size, in bytes, of the call/branch/jmp instruction</param>
        /// <param name="dst">The call/branch/jmp target</param>
        [MethodImpl(Inline), Op]
        public static uint offset(MemoryAddress src, byte fxSize, MemoryAddress dst)
            => (uint)(dst - (src + fxSize));

    }
}