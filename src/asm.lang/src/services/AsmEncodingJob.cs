//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmEncodingJob
    {
        readonly Index<AsmEncodingTask> _Tasks;

        public Span<AsmEncodingTask> Tasks
        {
            [MethodImpl(Inline)]
            get => _Tasks.Edit;
        }

        public uint TaskCount
        {
            [MethodImpl(Inline)]
            get => _Tasks.Count;
        }

        public AsmEncodingJob(uint count)
        {
            _Tasks = sys.alloc<AsmEncodingTask>(count);
        }

        [MethodImpl(Inline)]
        public AsmEncodingJob(Index<AsmEncodingTask> src)
        {
            _Tasks = src.Storage;
        }
    }
}