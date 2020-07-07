//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static BufferSeqId;

    partial struct Evaluate
    {
        public static ref readonly UnaryEvaluations<T> compute<T>(in UnaryEvalContext<T> exchange)
            where T : unmanaged
        {
            var f = exchange.Member.Method.CreateDelegate<UnaryOp<T>>();
            var g = Dynamic.EmitUnaryOp<T>(exchange.Buffers[Left], exchange.ApiBits);
            var srcCount = exchange.SrcCount;
            var dstCount = exchange.DstCount;
            var count = core.min(srcCount,dstCount);

            for(var i=0; i<count; i++)
            {
                ref readonly var x = ref exchange.Src[i];
                exchange.Dst[i] = (f(x), g(x));
            }   
            
            return ref exchange.Content;         
        }

        public static ref readonly BinaryEvaluations<T> compute<T>(in BinaryEvalContext<T> exchange)
            where T : unmanaged
        {
            var f = exchange.Member.Method.CreateDelegate<BinaryOp<T>>();
            var g = Dynamic.EmitBinaryOp<T>(exchange.Buffers[Left], exchange.ApiBits);
            var srcCount = exchange.SrcCount;
            var dstCount = exchange.DstCount;
            var count = core.min(srcCount,dstCount);

            for(var i=0; i<count; i++)
            {
                ref readonly var pair = ref exchange.Src[i];
                ref readonly var x = ref pair.Left;
                ref readonly var y = ref pair.Right;
                
                exchange.Dst[i] = (f(x,y), g(x, y));
            }

            return ref exchange.Content;         
        }    

        static IDynexus Dynamic => Dynops.Services.Dynexus;
    }
}