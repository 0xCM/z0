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
        public static FarCallSummary Define(MemoryAddress[] targets, MemoryAddress[] bases, MemoryAddress[] hosted, MemoryAddress[] unhosted)
            => new FarCallSummary(targets, bases, hosted, unhosted);
        
        [MethodImpl(Inline)]
        FarCallSummary(MemoryAddress[] targets, MemoryAddress[] bases, MemoryAddress[] hosted, MemoryAddress[] unhosted)
        {
            this.FarCallTargets = targets;
            this.HostBases = bases;
            this.HostedReceivers = hosted;
            this.UnhostedReceivers = unhosted;
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
        public readonly MemoryAddress[] HostedReceivers;

        /// <summary>
        /// Far call targets that are not defined by an api host
        /// </summary>
        public readonly MemoryAddress[] UnhostedReceivers;

        public FarCallCounts Counts
            => FarCallCounts.Define(
                FarCallTargets.Length, 
                HostBases.Length, 
                HostedReceivers.Length, 
                UnhostedReceivers.Length);

        public string Format()
            => Counts.Format();
    }
}