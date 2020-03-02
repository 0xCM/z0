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

    public readonly struct FarCallCounts
    {
        [MethodImpl(Inline)]
        public static FarCallCounts Define(int targets, int hosted, int hostedTargets, int unhostedTargets)
            => new FarCallCounts(targets,hosted,hostedTargets,unhostedTargets);
        
        [MethodImpl(Inline)]
        FarCallCounts(int targets, int hosted, int hostedTargets, int unhostedTargets)
        {
            this.TargetCount = targets;
            this.HostedCount = hosted;
            this.HostTargetCount = hostedTargets;
            this.UnhostedTargetCount = unhostedTargets;
        }

        /// <summary>
        /// The distinct count of far-call target addresses
        /// </summary>
        public readonly int TargetCount;

        /// <summary>
        /// The distinct count of host-defined addresses
        /// </summary>
        public readonly int HostedCount;

        /// <summary>
        /// The distinct count of host-defined addresses that are targets of a far-call
        /// </summary>
        public readonly int HostTargetCount;

        /// <summary>
        /// The distinct count of far-call target addresses that are not provided by a howt
        /// </summary>
        public readonly int UnhostedTargetCount;

        const char eol = AsciSym.Colon;

        const int pad = 10;

        const char sep = AsciSym.Pipe;

        public string Format()
        {            
            var dst = text.factory.Builder();
            var fieldSep = text.pipe();
            var labelSep = text.colon();

            dst.AppendLabeled(nameof(TargetCount), eol, TargetCount);
            dst.DelimitLabeled(nameof(HostedCount), eol, HostedCount, pad, sep);
            dst.DelimitLabeled(nameof(HostTargetCount), eol, HostTargetCount, pad, sep);
            dst.DelimitLabeled(nameof(UnhostedTargetCount), eol, UnhostedTargetCount, pad, sep);

            return dst.ToString();
        }
    }
}