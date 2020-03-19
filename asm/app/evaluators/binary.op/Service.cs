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
    using static BufferSeqId;
    using static EvalPackages;    

    readonly struct BinaryOpEvaluator<T> : IBinaryOpEvaluator<T>
        where T : unmanaged
    {
        public IAsmWorkflowContext Context {get;}

        [MethodImpl(Inline)]
        public BinaryOpEvaluator(IAsmWorkflowContext context)
        {
            this.Context = context;
        }

        public ref readonly BinaryEval<T> Evaluate(in BinaryOpPackage<T> package)
        {
            var f = package.ApiCode.Member.Method.CreateDelegate<BinaryOp<T>>();
            var g = package.Buffers[Left].EmitBinaryOp<T>(package.ApiCode);
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