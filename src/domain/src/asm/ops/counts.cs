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
        /// Summarizes far-call summary count statistics
        /// </summary>
        /// <param name="src">The summary over which to compute count statistics</param>
        [MethodImpl(Inline), Op]
        public static FarCallCounts counts(in FarCallSummary src)
            => new FarCallCounts(
                src.FarCallTargets.Length, 
                src.HostBases.Length, 
                src.HostedReceivers.Length, 
                src.UnhostedReceivers.Length);
    }
}