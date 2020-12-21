//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ExecutorContext
    {
        public IPolyStream DataSource {get;}

        public uint PointCount {get;}

        public uint Sequence {get;}

        internal ExecutorContext(IPolyStream src, uint count, uint seq)
        {
            DataSource = src;
            PointCount = count;
            Sequence = seq;
        }

        public ExecutorContext Next
        {
            [MethodImpl(Inline)]
            get => new ExecutorContext(DataSource, PointCount, Sequence + 1);
        }
    }
}