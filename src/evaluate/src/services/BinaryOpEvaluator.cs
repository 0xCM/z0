//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static BufferSeqId;

    readonly struct BinaryOpEvaluator<T> : IBinaryOpEvaluator<T>
        where T : unmanaged
    {
        IDynexus Dynamic => Dynops.Services.Dynexus;

        public ref readonly BinaryEval<T> Evaluate(in BinaryOpEval<T> exchange)
        {
            var f = exchange.ApiCode.Member.Method.CreateDelegate<BinaryOp<T>>();
            var g = Dynamic.EmitBinaryOp<T>(exchange.Buffers[Left], exchange.ApiCode.Encoded);

            for(var i=0; i<exchange.SrcCount; i++)
            {
                ref readonly var pair = ref exchange.Src[i];
                ref readonly var x = ref pair.Left;
                ref readonly var y = ref pair.Right;
                
                exchange.Dst.Target[i] = (f(x,y), g(x, y));
            }   
            return ref exchange.Content;         
        }    
    }
}