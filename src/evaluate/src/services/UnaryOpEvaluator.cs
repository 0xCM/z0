//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static BufferSeqId;

    readonly struct UnaryOpEvaluator<T> : IUnaryOpEvaluator<T>
        where T : unmanaged
    {
        IDynexus Dynamic => Dynops.Services.Dynexus;

        public ref readonly UnaryEval<T> Evaluate(in UnaryOpEval<T> exchange)
        {
            var f = exchange.ApiCode.Member.Method.CreateDelegate<UnaryOp<T>>();
            var g = Dynamic.EmitUnaryOp<T>(exchange.Buffers[Left], exchange.ApiCode);

            for(var i=0; i<exchange.SrcCount; i++)
            {
                ref readonly var x = ref exchange.Src[i];
                exchange.Dst.Target[i] = (f(x), g(x));
            }   
            
            return ref exchange.Content;         
        }
    }
}