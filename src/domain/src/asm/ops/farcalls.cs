//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asm
    {
        /// <summary>
        /// Summarizes a collection of far-call datapoints
        /// </summary>
        /// <param name="targets">The call target addresses</param>
        /// <param name="bases">The base addresses of the callers</param>
        /// <param name="hosted">Base addresses of api host functions that are targets of a far call</param>
        /// <param name="unhosted">Far call targets that are not defined by an api host</param>
        [MethodImpl(Inline), Op]
        public static FarCallSummary farcalls(MemoryAddress[] targets, MemoryAddress[] bases, MemoryAddress[] hosted, MemoryAddress[] unhosted)
            => new FarCallSummary(targets, bases, hosted, unhosted);
    }
}