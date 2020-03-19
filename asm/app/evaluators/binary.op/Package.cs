//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class EvalPackages
    {
        public readonly ref struct BinaryOpPackage<T>
            where T : unmanaged
        {            
            [MethodImpl(Inline)]
            internal BinaryOpPackage(in ApiEvalContext context, in PairEval<T> content)
            {
                this.Context = context;
                this.Content = content;
            }

            public readonly ApiEvalContext Context;

            public readonly PairEval<T> Content;

            public Pairs<T> Src 
            {
                [MethodImpl(Inline)]
                get => Content.Source;
            }

            public Pairs<T> Dst 
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