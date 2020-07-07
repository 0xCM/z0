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

        public readonly BinaryEvaluations<T> Content;

        [MethodImpl(Inline)]
        public BinaryEvalContext(in EvalContext context, in BinaryEvaluations<T> content)
        {
            Context = context;
            Content = content;
        }

        public Pairs<T> Src 
        {
            [MethodImpl(Inline)]
            get => Content.Source;
        }

        public PairEvalOutcomes<T> Dst 
        {
            [MethodImpl(Inline)]
            get => Content.Target;
        }

        public int SrcCount
            => Content.Source.Count;

        public int DstCount
            => Content.Target.Count;
        
        public BufferTokens Buffers
            => Context.Buffers;
        
        public ApiCode ApiCode
            => Context.ApiCode;

        public ApiMember Member 
            => Context.Member;

        public IdentifiedCode ApiBits 
            => Context.ApiBits;            
    }
}