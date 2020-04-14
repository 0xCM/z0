//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class EvalPackages
    {
        public readonly ref struct UnaryOpPackage<T>
            where T : unmanaged
        {            
            [MethodImpl(Inline)]
            internal UnaryOpPackage(in ApiEvalContext context, in BinaryEval<T> content)
            {
                this.Context = context;
                this.Content = content;
            }

            public readonly ApiEvalContext Context;

            public readonly BinaryEval<T> Content;

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
            
            public BufferSeq Buffers
                => Context.Buffers;
            
            public ApiMemberCode ApiCode
                => Context.ApiCode;
        }
    }
}