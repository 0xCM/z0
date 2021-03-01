//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct WfExecToken
    {
        public ulong StartSeq;

        public Timestamp Started;

        public Timestamp? Finished;

        public ulong EndSeq;

        [MethodImpl(Inline)]
        public WfExecToken(ulong seq)
        {
            StartSeq = seq;
            Started = root.timestamp();
            Finished = null;
            EndSeq = 0;
        }

        [MethodImpl(Inline)]
        public WfExecToken Complete(ulong seq)
        {
            EndSeq = seq;
            Finished = root.timestamp();
            return this;
        }

        public string Format()
            => string.Format("{0} | {1} | {2}", string.Format("{0:D4}:{1:D4}", StartSeq, EndSeq), Started, Finished ?? Timestamp.Zero);

        public override string ToString()
            => Format();
    }
}