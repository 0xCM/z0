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
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress offset(in AsmCall src)
            => src.Client.Base + src.CallSite;

        /// <summary>
        /// Defines a <see cref='AsmScaledOffset'/>
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="offset"></param>
        /// <param name="scale"></param>
        [MethodImpl(Inline), Op]
        public static AsmScaledOffset offset(MemoryAddress @base, Address16 offset, byte scale)
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