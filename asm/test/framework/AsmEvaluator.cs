//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    using static BufferSeqId;

    public readonly ref struct AsmEvaluator
    {
        readonly IAsmWorkflowContext Context;

        readonly BufferSeq buffers;

        readonly IPolyrand Random;

        [MethodImpl(Inline)]        
        public static AsmEvaluator Create(IAsmWorkflowContext context, in BufferSeq buffers)
            => new AsmEvaluator(context,buffers);

        [MethodImpl(Inline)]        
        AsmEvaluator(IAsmWorkflowContext context, in BufferSeq buffers)
        {
            this.Context = context;
            this.buffers = buffers;
            this.Random = context.Random;
        }

        /// <summary>
        /// Evaluates a binary operator over a caller-supplied source point index
        /// </summary>
        /// <param name="api">The api member</param>
        /// <param name="src">The source point index</param>
        /// <typeparam name="T">The operand type</typeparam>
        public HomPoints<N3,T> EvalOperator<T>(in ApiMemberCode api, HomPoints<N2,T> src)
            where T : unmanaged
        {
            var count = src.Count;
            var f = buffers[Left].EmitBinaryOp<T>(api);
            var dst = Points.homalloc<N3,T>(src.Count,n3);
            for(var i=0; i<count; i++)
            {
                var point = src[i];
                ref readonly var x0 = ref point[n0];
                ref readonly var x1 = ref point[n1];
                dst[i] =  Points.point(x0, x1, f(x0,x1),n3);
            }
            return dst;
        }

        public HomPoints<N3,F> EvalFixedOperator<F>(in ApiMemberCode api, HomPoints<N2,F> src)
            where F : unmanaged, IFixed
        {
            var count = src.Count;
            var f = buffers[Left].EmitFixedBinaryOp<F>(api.ApiCode);
            var dst = Points.homalloc<N3,F>(src.Count);
            for(var i=0; i<count; i++)
            {
                var point = src[i];
                ref readonly var x0 = ref point[n0];
                ref readonly var x1 = ref point[n1];
                dst[i] = (x0, x1, f(x0,x1));
            }
            return dst;
        }

    }
}