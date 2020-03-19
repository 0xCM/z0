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
    using static Nats;
    using static Classes;

    using static BufferSeqId;

    public static class AsmEvaluators
    {
        public static AsmEvaluator Evaluator0<E,T>(this IAsmWorkflowContext context, in BufferSeq buffers, IOpClass<E,T> k)
            where T : unmanaged
            where E : unmanaged, Enum
                => AsmEvaluator.Create(context, buffers);
    }

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
        /// Evaluates a binary operator over a pair index and deposits the result into a caller-supplied triple index
        /// </summary>
        /// <param name="api">The api member</param>
        /// <param name="src">The source pairs over which to evaluate the operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        public ref readonly Triples<T> Eval<T>(in ApiMemberCode api, BinaryOp op, in Pairs<T> src, in Triples<T> dst)
            where T : unmanaged
        {
            var count = src.Count;
            var f = buffers[Left].EmitBinaryOp<T>(api);
            for(var i=0; i<count; i++)
            {
                ref readonly var pair = ref src[i];
                dst[i] =  Tuples.triple(pair.Left, pair.Right, f(pair.Left,pair.Right));
            }
            return ref dst;
        }

        /// <summary>
        /// Evaluates a binary operator over a pair index
        /// </summary>
        /// <param name="api">The api member</param>
        /// <param name="src">The source pairs over which to evaluate the operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        public Triples<T> Eval<T>(in ApiMemberCode api, BinaryOp op, in Pairs<T> src)
            where T : unmanaged
                => Eval(api,op, src, Triples.alloc<T>(src.Count));

        /// <summary>
        /// Evaluates a binary operator over a pair index of fixed types
        /// </summary>
        /// <param name="api">The api member</param>
        /// <param name="src">The source pairs over which to evaluate the operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        public Triples<F> EvalFixed<F>(in ApiMemberCode api, BinaryOp op, in Pairs<F> src)
            where F : unmanaged, IFixed
        {
            var count = src.Count;
            var f = buffers[Left].EmitBinaryOp<F>(api);
            var dst = Triples.alloc<F>(src.Count);
            for(var i=0; i<count; i++)
            {
                ref readonly var pair = ref src[i];
                dst[i] =  Tuples.triple(pair.Left, pair.Right, f(pair.Left,pair.Right));
            }
            return dst;
        }
    }
}