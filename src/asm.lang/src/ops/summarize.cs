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
        /// Summarizes a collection of far-call datapoints
        /// </summary>
        /// <param name="sources">The base addresses of the calling blocks</param>
        /// <param name="targets">The addresses at which the target call instruction is issued</param>
        /// <param name="targets">The call targets</param>
        [MethodImpl(Inline), Op]
        public static AsmCallSummary summarize(Index<AsmCallInfo> calls)
            => new AsmCallSummary(calls);
    }
}