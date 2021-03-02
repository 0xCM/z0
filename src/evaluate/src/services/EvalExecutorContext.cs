//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EvalExecutorContext
    {
        public IDomainSource DataSource {get;}

        public uint PointCount {get;}

        public uint Sequence {get;}

        internal EvalExecutorContext(IDomainSource src, uint count, uint seq)
        {
            DataSource = src;
            PointCount = count;
            Sequence = seq;
        }

        public EvalExecutorContext Next
        {
            [MethodImpl(Inline)]
            get => new EvalExecutorContext(DataSource, PointCount, Sequence + 1);
        }
    }
}