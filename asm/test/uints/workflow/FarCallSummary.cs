//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Root;

    public readonly struct FarCallSummary
    {
        [MethodImpl(Inline)]
        public static FarCallSummary Define(MemoryAddress[] targets, MemoryAddress[] hosted, MemoryAddress[] known, MemoryAddress[] unknown)
            => new FarCallSummary(targets, hosted, known, unknown);
        
        [MethodImpl(Inline)]
        FarCallSummary(MemoryAddress[] targets, MemoryAddress[] hosted, MemoryAddress[] known, MemoryAddress[] unknown)
        {
            this.FarCallTargets = targets;
            this.HostBases = hosted;
            this.HostTargets = known;
            this.UnhostedTargets = unknown;
        }
        
        /// <summary>
        /// Far-classified call instruction operations
        /// </summary>
        public readonly MemoryAddress[] FarCallTargets;

        /// <summary>
        /// Base addresses of functions defined by an api host
        /// </summary>
        public readonly MemoryAddress[] HostBases;

        /// <summary>
        /// Base addresses of api host functions that are targets of a far call
        /// </summary>
        public readonly MemoryAddress[] HostTargets;

        /// <summary>
        /// Far call targets that are not defined by an api host
        /// </summary>
        public readonly MemoryAddress[] UnhostedTargets;


        public FarCallCounts Counts
            => FarCallCounts.Define(
                FarCallTargets.Length, 
                HostBases.Length, 
                HostTargets.Length, 
                UnhostedTargets.Length);

        public string Format()
            => Counts.Format();
    }
}