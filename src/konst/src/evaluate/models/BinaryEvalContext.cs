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

        public PairEvalOutcomes<T> Outcomes
        {
            [MethodImpl(Inline)]
            get => Target.Target;
        }

        public int PointCount
            => Target.Source.PointCount;

        public BufferTokens Buffers
            => Context.Buffers;

        public X86ApiMember ApiCode
            => Context.ApiCode;

        public ApiMember Member
            => Context.Member;

        public X86UriHex ApiBits
            => Context.ApiBits;
    }
}