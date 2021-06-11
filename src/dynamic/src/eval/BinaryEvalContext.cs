//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly ref struct BinaryEvalContext<T>
        where T : unmanaged
    {
        public EvalContext Context {get;}

        public readonly BinaryEvaluations<T> Target;

        [MethodImpl(Inline)]
        public BinaryEvalContext(in EvalContext context, in BinaryEvaluations<T> dst)
        {
            root.invariant(dst.Source.PointCount == dst.Target.PointCount, () => "no");
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

        public uint PointCount
            => Target.Source.PointCount;

        public BufferTokens Buffers
            => Context.Buffers;

        public ApiMemberCode ApiCode
            => Context.ApiCode;

        public ApiMember Member
            => Context.Member;

        public ApiCodeBlock ApiBits
            => Context.ApiBits;
    }
}