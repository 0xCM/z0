//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittedDataset : IAppEvent<EmittedDataset>
    {
        const string Pattern = "{0}: Emitted {1} {2} records to {3}";

        public readonly StringRef DataType;

        public readonly uint RecordCount;

        public readonly FilePath TargetPath;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public EmittedDataset(string type, uint count, FilePath target)
        {
            DataType = type;
            RecordCount = count;
            TargetPath = target;
            Timestamp = z.now();
        }        
        public string Format()
            => text.format(Pattern, Timestamp, RecordCount, TargetPath.Name, Timestamp.Format());

        public string Description
            => Format();
        
        public override string ToString()
            => Format();
    }
}