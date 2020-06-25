//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct UnaryOpEval<T>
        where T : unmanaged
    {            
        public readonly ApiCodeEval Context;

        public readonly UnaryEval<T> Content;

        public Span<T> Src 
        { 
            [MethodImpl(Inline)] 
            get => Content.Source; 
        }

        public PairEval<T> Dst 
        {
             [MethodImpl(Inline)] 
             get => Content.Target; 
        }

        public int SrcCount 
            => Content.Source.Length;
        
        public BufferTokens Buffers 
            => Context.Buffers;
        
        public ApiMember Member 
            => Context.Member;

        public IdentifiedCode ApiBits 
            => Context.ApiBits;

        [MethodImpl(Inline)]
        public UnaryOpEval(in ApiCodeEval context, in UnaryEval<T> content)
        {
            Context = context;
            Content = content;
        }
    }
}