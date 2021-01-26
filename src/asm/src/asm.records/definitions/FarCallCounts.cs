//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record(TableId)]
    public struct FarCallCounts : IRecord<FarCallCounts>
    {
        public const string TableId = "asm.far-call-counts";

        /// <summary>
        /// The distinct count of far-call target addresses
        /// </summary>
        public uint TargetsFar;

        /// <summary>
        /// The distinct count of host-defined addresses
        /// </summary>
        public uint HostedCount;

        /// <summary>
        /// The distinct count of host-defined addresses that are targets of a far-call
        /// </summary>
        public uint HostedReceivers;

        /// <summary>
        /// The distinct count of far-call target addresses that are not provided by a howt
        /// </summary>
        public uint UnhostedReceivers;

        [MethodImpl(Inline)]
        public FarCallCounts(uint targets, uint hosted, uint hostedTargets, uint unhostedTargets)
        {
            TargetsFar = targets;
            HostedCount = hosted;
            HostedReceivers = hostedTargets;
            UnhostedReceivers = unhostedTargets;
        }
    }
}