//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmCallSummary
    {
        /// <summary>
        /// Far-classified call instruction operations
        /// </summary>
        public MemoryAddress[] FarCallTargets {get;}

        /// <summary>
        /// Base addresses of functions defined by an api host
        /// </summary>
        public MemoryAddress[] HostBases {get;}

        /// <summary>
        /// Base addresses of api host functions that are targets of a far call
        /// </summary>
        public MemoryAddress[] HostedReceivers {get;}

        /// <summary>
        /// Far call targets that are not defined by an api host
        /// </summary>
        public MemoryAddress[] UnhostedReceivers {get;}

        [MethodImpl(Inline)]
        public AsmCallSummary(MemoryAddress[] targets, MemoryAddress[] bases, MemoryAddress[] hosted, MemoryAddress[] unhosted)
        {
            FarCallTargets = targets;
            HostBases = bases;
            HostedReceivers = hosted;
            UnhostedReceivers = unhosted;
        }
    }
}