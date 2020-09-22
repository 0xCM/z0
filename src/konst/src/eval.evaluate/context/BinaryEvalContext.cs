//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct BinaryEvalContext<T>
        where T : unmanaged
    {
        public readonly EvalContext Context;

        public readonly BinaryEvaluations<T> Target;

        [MethodImpl(Inline)]
        public BinaryEvalContext(in EvalContext context, in BinaryEvaluations<T> dst)
        {
            Demands.insist(dst.Source.PointCount, dst.Target.PointCount);
            Context = context;
            Target = dst;
        }

        public Pairs<T> Input
        {
            [MethodImpl(Inline)]
            get => Target.Source;
        }

        public PairEvalResults<T> Outcomes
        {
            [MethodImpl(Inline)]
            get => Target.Target;
        }

        public int PointCount
            => Target.Source.PointCount;

        public BufferTokens Buffers
            => Context.Buffers;

        public ApiMemberHex ApiCode
            => Context.ApiCode;

        public ApiMember Member
            => Context.Member;

        public ApiHex ApiBits
            => Context.ApiBits;
    }
}