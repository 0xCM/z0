//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct FarCallCounts
    {
        [MethodImpl(Inline)]
        public static FarCallCounts Define(int targets, int hosted, int hostedTargets, int unhostedTargets)
            => new FarCallCounts(targets, hosted, hostedTargets, unhostedTargets);
        
        [MethodImpl(Inline)]
        FarCallCounts(int targets, int hosted, int hostedTargets, int unhostedTargets)
        {
            this.TargetsFar = targets;
            this.HostedCount = hosted;
            this.HostedReceivers = hostedTargets;
            this.UnhostedReceivers = unhostedTargets;
        }

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

        const char eol = Chars.Colon;

        const int pad = 10;

        const char sep = Chars.Pipe;

        public string Format()
        {            
            var dst = text.build();
            dst.AppendLabeled(nameof(TargetsFar), eol, TargetsFar);
            dst.AppendDelimited(nameof(HostedReceivers), eol, HostedReceivers, pad, sep);
            dst.AppendDelimited(nameof(UnhostedReceivers), eol, UnhostedReceivers, pad, sep);
            return dst.ToString();
        }
    }
}