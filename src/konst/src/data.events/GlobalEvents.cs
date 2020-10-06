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

        public const string Trace = nameof(Trace);

        public const string Status = nameof(Status);

        public const string Warning = nameof(Warning);

        public const string Error = nameof(Error);

        public const string TableEmitted = nameof(TableEmitted);

        public const string FileEmitted = nameof(FileEmitted);
    }
}