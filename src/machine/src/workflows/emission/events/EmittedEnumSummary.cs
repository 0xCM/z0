//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittedEnumSummary : IAppEvent<EmittedEnumSummary>
    {
        const string Pattern = "{0} Emitted summary data file for {1} enum literals to {2}";

        public readonly FilePath TargetPath;

        public readonly uint RecordCount;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public EmittedEnumSummary(FilePath target, uint count, Timestamp? ts = null)
        {
            TargetPath = target;
            RecordCount = count;
            Timestamp = ts ?? z.now();
        }        
        public string Format()
            => text.format(Pattern, Timestamp, RecordCount, TargetPath);

        public string Description
            => Format();
        
        public override string ToString()
            => Format();
    }
}