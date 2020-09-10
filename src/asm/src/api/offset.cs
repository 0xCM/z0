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
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress offset(in AsmCall src)
            => src.Client.Base + src.CallSite;

        [MethodImpl(Inline), Op]
        public static ScaledOffset offset(ulong @base, ushort offset, byte scale)
            => new ScaledOffset(@base, offset, scale);
    }
}