//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct UnaryEvalContext<T>
        where T : unmanaged
    {
        public readonly EvalContext Context;

        public readonly UnaryEvaluations<T> Target;

        [MethodImpl(Inline)]
        internal UnaryEvalContext(in EvalContext context, in UnaryEvaluations<T> dst)
        {
            Demands.insist(dst.Source.Length, dst.Target.PointCount);
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

        public int PointCount
            => Target.Source.Length;

        public int DstCount
            => Target.Target.PointCount;

        public X86ApiMember ApiCode
            => Context.ApiCode;

        public BufferTokens Buffers
            => Context.Buffers;

        public ApiMember Member
            => Context.Member;

        public ApiHex ApiBits
            => Context.ApiBits;
    }
}