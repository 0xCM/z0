//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct FarCallCounts
    {
        /// <summary>
        /// The distinct count of far-call target addresses
        /// </summary>
        public readonly int TargetsFar;

        /// <summary>
        /// The distinct count of host-defined addresses
        /// </summary>
        public readonly int HostedCount;

        /// <summary>
        /// The distinct count of host-defined addresses that are targets of a far-call
        /// </summary>
        public readonly int HostedReceivers;

        /// <summary>
        /// The distinct count of far-call target addresses that are not provided by a howt
        /// </summary>
        public readonly int UnhostedReceivers;

        [MethodImpl(Inline)]
        public FarCallCounts(int targets, int hosted, int hostedTargets, int unhostedTargets)
        {
            TargetsFar = targets;
            HostedCount = hosted;
            HostedReceivers = hostedTargets;
            UnhostedReceivers = unhostedTargets;
        }
    }
}