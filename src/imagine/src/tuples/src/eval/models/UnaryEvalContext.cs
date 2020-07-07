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

        public readonly UnaryEvaluations<T> Content;

        [MethodImpl(Inline)]
        internal UnaryEvalContext(in EvalContext context, in UnaryEvaluations<T> content)
        {
            Context = context;
            Content = content;
        }
        
        public Span<T> Src 
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
            => Content.Source.Length;

        public int DstCount 
            => Content.Target.Count;
        

        public BufferTokens Buffers 
            => Context.Buffers;
        
        public ApiMember Member 
            => Context.Member;

        public IdentifiedCode ApiBits 
            => Context.ApiBits;
    }
}