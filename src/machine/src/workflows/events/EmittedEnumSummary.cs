//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittedEnumSummary : IWfEvent<EmittedEnumSummary>
    {
        const string Pattern = "{0}: Emitted summary data file for {1} enum literals to {2}";

        public WfEventId Id {get;}

        public readonly FilePath TargetPath;

        public readonly uint RecordCount;

        [MethodImpl(Inline)]
        public EmittedEnumSummary(FilePath target, uint count, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(nameof(EmittedEnumSummary), ct ?? CorrelationToken.create(), z.now());
            TargetPath = target;
            RecordCount = count;
        }        
        public string Format()
            => text.format(Pattern, Id, RecordCount, TargetPath);
    }
}