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

    public readonly struct QuadRef<T>
        where T : struct
    {
        readonly Vector512<ulong> Segments;

        public Ref<T> S0
        {
            [MethodImpl(Inline)]
            get => new Ref<T>(Segments[n0]);
        }

        public Ref<T> S1
        {
            [MethodImpl(Inline)]
            get => new Ref<T>(Segments[n1]);
        }

        public Ref<T> S2
        {
            [MethodImpl(Inline)]
            get => new Ref<T>(Segments[n2]);
        }

        public Ref<T> S3
        {
            [MethodImpl(Inline)]
            get => new Ref<T>(Segments[n3]);
        }


        [MethodImpl(Inline)]
        public QuadRef(in T s0, in T s1, in T s2, in T s3)
            => Segments = v512<ulong>(
                MemRefs.from(s0).Segment.Segment,
                MemRefs.from(s1).Segment.Segment,
                MemRefs.from(s2).Segment.Segment,
                MemRefs.from(s3).Segment.Segment
                );

        public string Format()
            => text.concat(
                "s0 = ", S0.BaseAddress, text.bracket(S0.CellCount), Space, text.embrace(S0.Data.Format()),
                "s1 = ", S1.BaseAddress, text.bracket(S1.CellCount), Space, text.embrace(S1.Data.Format()),
                "s2 = ", S2.BaseAddress, text.bracket(S2.CellCount), Space, text.embrace(S2.Data.Format()),
                "s3 = ", S3.BaseAddress, text.bracket(S3.CellCount), Space, text.embrace(S3.Data.Format())
                );

        public override string ToString()
            => Format();
    }
}