//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExecutorContext
    {
        public readonly IPolyrand DataSource;

        public readonly uint PointCount;

        public readonly uint Sequence;
        
        internal ExecutorContext(IPolyrand src, uint count, uint seq)
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