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
    using static EvalPackages;    

    readonly struct BinaryOpEvalService<T> : IBinaryOpEvalService<T>
        where T : unmanaged
    {
        IDynamicOps Dynamic => IContext.Default.Dynamic();

        public ref readonly BinaryEval<T> Evaluate(in BinaryOpEval<T> package)
        {
            var f = package.ApiCode.Member.Method.CreateDelegate<BinaryOp<T>>();
            //var g = package.Buffers[Left].EmitBinaryOp<T>(package.ApiCode);
            var g = Dynamic.EmitBinaryOp<T>(package.Buffers[Left], package.ApiCode);

            for(var i=0; i<package.SrcCount; i++)
            {
                ref readonly var pair = ref package.Src[i];
                ref readonly var x = ref pair.Left;
                ref readonly var y = ref pair.Right;
                
                package.Dst.Target[i] = (f(x,y), g(x, y));
            }   
            return ref package.Content;         
        }
    }
}