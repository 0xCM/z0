//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct BinaryOpEval<T>
        where T : unmanaged
    {            
        public readonly ApiCodeEval Context;

        public readonly BinaryEval<T> Content;

        [MethodImpl(Inline)]
        public BinaryOpEval(in ApiCodeEval context, in BinaryEval<T> content)
        {
            this.Context = context;
            this.Content = content;
        }

        public Pairs<T> Src 
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
            => Content.Source.Count;
        
        public BufferTokens Buffers
            => Context.Buffers;
        
        public ApiCode ApiCode
            => Context.ApiCode;
    }
}