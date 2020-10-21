//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct GlobalEvents
    {
        public const string Created = nameof(Created);

        public const string Disposed = nameof(Disposed);

        public const string Running = nameof(Running);

        public const string Ran = nameof(Ran);

        public const string RanCmd = nameof(RanCmd);

        public const string RunningCmd = nameof(RunningCmd);

        public const string Trace = nameof(Trace);

        public const string Status = nameof(Status);

        public const string Warning = nameof(Warning);

        public const string Error = nameof(Error);

        public const string EmittedTable = nameof(EmittedTable);

        public const string EmittingFile = nameof(EmittingFile);

        public const string EmittedFile = nameof(EmittedFile);

        public const string Flowed = nameof(Flowed);

        public const string Processed = nameof(Processed);

        public const string ProcessingFile = nameof(ProcessingFile);

        public const string ProcessedFile = nameof(ProcessedFile);

        public const string ToolCreated = nameof(ToolCreated);

        public const string Rows = nameof(Rows);

        public const string EmittingTable = nameof(EmittingTable);
    }
}