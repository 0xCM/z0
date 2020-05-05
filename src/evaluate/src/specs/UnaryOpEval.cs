//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly ref struct UnaryOpEval<T>
        where T : unmanaged
    {            
        public readonly EvalContext Context;

        public readonly UnaryEval<T> Content;

        public Span<T> Src { [MethodImpl(Inline)] get => Content.Source; }

        public PairEval<T> Dst { [MethodImpl(Inline)] get => Content.Target; }

        public int SrcCount => Content.Source.Length;
        
        public BufferTokens Buffers => Context.Buffers;
        
        public ApiMember Member => Context.Member;

        public UriHex ApiBits => Context.ApiBits;

        [MethodImpl(Inline)]
        internal UnaryOpEval(in EvalContext context, in UnaryEval<T> content)
        {
            this.Context = context;
            this.Content = content;
        }
    }
}