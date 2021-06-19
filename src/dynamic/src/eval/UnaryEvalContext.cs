//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly ref struct UnaryEvalContext<T>
        where T : unmanaged
    {
        public readonly EvalContext Context;

        public readonly UnaryEvaluations<T> Target;

        [MethodImpl(Inline)]
        public UnaryEvalContext(in EvalContext context, in UnaryEvaluations<T> dst)
        {
            Require.invariant(dst.Source.Length == dst.Target.PointCount, () => "no");
            Context = context;
            Target = dst;
        }

        public Span<T> Input
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
            => (uint)Target.Source.Length;

        public uint DstCount
            => Target.Target.PointCount;

        public ApiMemberCode ApiCode
            => Context.ApiCode;

        public BufferTokens Buffers
            => Context.Buffers;

        public ApiMember Member
            => Context.Member;

        public ApiCodeBlock ApiBits
            => Context.ApiBits;
    }
}