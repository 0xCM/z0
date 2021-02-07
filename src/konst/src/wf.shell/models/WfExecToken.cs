//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public struct WfExecToken
    {
        public ulong StartSeq;

        public Timestamp Started;

        public Timestamp? Finished;

        public ulong EndSeq;

        [MethodImpl(Inline)]
        public WfExecToken(ulong seq, Timestamp? started = null)
        {
            StartSeq = seq;
            Started = started ?? timestamp();
            Finished = null;
            EndSeq = 0;
        }

        [MethodImpl(Inline)]
        public WfExecToken Complete(ulong seq, Timestamp? finished = null)
        {
            EndSeq = seq;
            Finished = finished ?? timestamp();
            return this;
        }

        public string Format()
        {
            var ts = Finished != null ? Finished.Value : Started;
            var seq = string.Format("{0}:{1}", StartSeq, EndSeq);
            return string.Format("{0} | {1}", seq, ts);
        }

        public override string ToString()
            => Format();
    }
}