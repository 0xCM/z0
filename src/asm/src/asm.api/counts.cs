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
        /// Summarizes far-call summary count statistics
        /// </summary>
        /// <param name="src">The summary over which to compute count statistics</param>
        [MethodImpl(Inline), Op]
        public static FarCallCounts counts(in AsmCallSummary src)
            => new FarCallCounts(src.FarCallTargets.Count, src.HostBases.Count, src.HostedReceivers.Count, src.UnhostedReceivers.Count);
    }
}