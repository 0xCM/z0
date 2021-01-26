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
        public static AsmCallClient client(MemoryAddress @base)
            => new AsmCallClient(@base);

        [MethodImpl(Inline), Op]
        public static AsmCallClient client(string id, MemoryAddress @base)
            => new AsmCallClient(id, @base);

        /// <summary>
        /// Summarizes a collection of far-call datapoints
        /// </summary>
        /// <param name="targets">The call target addresses</param>
        /// <param name="bases">The base addresses of the callers</param>
        /// <param name="hosted">Base addresses of api host functions that are targets of a far call</param>
        /// <param name="unhosted">Far call targets that are not defined by an api host</param>
        [MethodImpl(Inline), Op]
        public static AsmCallSummary farcalls(Index<MemoryAddress> targets, Index<MemoryAddress> bases, Index<MemoryAddress> hosted, Index<MemoryAddress> unhosted)
            => new AsmCallSummary(targets, bases, hosted, unhosted);
    }
}