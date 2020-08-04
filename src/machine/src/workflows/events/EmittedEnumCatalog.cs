//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct EmittedEnumCatalog : IWfEvent<EmittedEnumCatalog>
    {
        const string Pattern = IdMarker + "Emitted summary data file for {1} enum literals to {2}";

        public WfEventId Id {get;}

        public readonly FilePath TargetPath;

        public readonly uint RecordCount;

        [MethodImpl(Inline)]
        public EmittedEnumCatalog(FilePath target, uint count, CorrelationToken ct)
        {
            Id = WfEventId.define(nameof(EmittedEnumCatalog), ct);
            TargetPath = target;
            RecordCount = count;
        }        
        
        public string Format()
            => text.format(Pattern, Id, RecordCount, TargetPath);
    }
}