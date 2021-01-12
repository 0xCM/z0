//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmCallSummary
    {
        /// <summary>
        /// Far-classified call instruction operations
        /// </summary>
        public Index<MemoryAddress> FarCallTargets {get;}

        /// <summary>
        /// Base addresses of functions defined by an api host
        /// </summary>
        public Index<MemoryAddress> HostBases {get;}

        /// <summary>
        /// Base addresses of api host functions that are targets of a far call
        /// </summary>
        public Index<MemoryAddress> HostedReceivers {get;}

        /// <summary>
        /// Far call targets that are not defined by an api host
        /// </summary>
        public Index<MemoryAddress> UnhostedReceivers {get;}

        [MethodImpl(Inline)]
        public AsmCallSummary(Index<MemoryAddress> targets, Index<MemoryAddress> bases, Index<MemoryAddress> hosted, Index<MemoryAddress> unhosted)
        {
            FarCallTargets = targets;
            HostBases = bases;
            HostedReceivers = hosted;
            UnhostedReceivers = unhosted;
        }
    }
}