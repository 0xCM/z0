//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using R = MemberParseReport;
    using E = AsmEvents.ParseReportCreated;

    partial class AsmEvents
    {
        /// <summary>
        /// Creates a <see cref="E" /> event
        /// </summary>
        /// <param name="src">The event payload</param>
        [MethodImpl(Inline)]
        public static E Define(R src)
            => E.Define(src);

        public readonly struct ParseReportCreated : IAppEvent<E,R>
        {
            public static E Empty => new E(MemberParseReport.Empty);

            [MethodImpl(Inline)]
            public static E Define(R report) => new E(report);

            [MethodImpl(Inline)]
            ParseReportCreated(R report)
            {
                this.Payload = report;
            }

            public R Payload {get;}

            public string Description
                => $"{Payload.RecordCount} records created for {Payload.ReportName}";
            
            public E Zero => Empty;
        }        
    }
}