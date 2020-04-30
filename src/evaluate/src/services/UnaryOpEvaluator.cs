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

        public ref readonly UnaryEval<T> Evaluate(in UnaryOpEval<T> package)
        {
            var f = package.ApiCode.Member.Method.CreateDelegate<UnaryOp<T>>();
            var g = Dynamic.EmitUnaryOp<T>(package.Buffers[Left], package.ApiCode);

            for(var i=0; i<package.SrcCount; i++)
            {
                ref readonly var x = ref package.Src[i];
                package.Dst.Target[i] = (f(x), g(x));
            }   
            
            return ref package.Content;         
        }
    }
}