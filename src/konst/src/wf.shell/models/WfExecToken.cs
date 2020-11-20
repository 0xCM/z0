//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct WfExecToken
    {
        public ulong StartSeq;

        public Timestamp Started;

        public Timestamp Finished;

        public ulong FinishedSeq;

        [MethodImpl(Inline)]
        public WfExecToken(ulong seq, Timestamp? started = null)
        {
            StartSeq = seq;
            Started = started ?? timestamp();
            Finished = Timestamp.Zero;
            FinishedSeq = 0;
        }

        [MethodImpl(Inline)]
        public WfExecToken Complete(ulong seq, Timestamp? ts = null)
        {
            FinishedSeq = seq;
            Finished = ts ?? timestamp();
            return this;
        }

        public string Format()
        {
            const string Pattern = "{0} | {1} | {2} | {4|";
            return string.Format(Pattern, StartSeq, Started, FinishedSeq, Finished);
        }

        public override string ToString()
            => Format();
    }
}