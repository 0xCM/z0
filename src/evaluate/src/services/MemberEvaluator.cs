//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static BufferSeqId;

    using K = Kinds;

    public readonly ref struct MemberEvaluator
    {
        readonly BufferSeq buffers;

        [MethodImpl(Inline)]        
        public static MemberEvaluator Create(in BufferSeq buffers)
            => new MemberEvaluator(buffers);

        [MethodImpl(Inline)]        
        MemberEvaluator(in BufferSeq buffers)
        {
            this.buffers = buffers;
        }

        IDynamicOps Dynamic => IContext.Default.Dynamic();

        /// <summary>
        /// Evaluates a binary operator over a pair index and deposits the result into a caller-supplied triple index
        /// </summary>
        /// <param name="api">The api member</param>
        /// <param name="src">The source pairs over which to evaluate the operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        public ref readonly Triples<T> Eval<T>(in MemberCode api, K.BinaryOpClass op, in Pairs<T> src, in Triples<T> dst)
            where T : unmanaged
        {
            var count = src.Count;
            //var f = buffers[Left].EmitBinaryOp<T>(api);
            var f = Dynamic.EmitBinaryOp<T>(buffers[Left], api);
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
        public Triples<T> Eval<T>(in MemberCode api, K.BinaryOpClass op, in Pairs<T> src)
            where T : unmanaged
                => Eval(api,op, src, Tuples.triples<T>(src.Count));

        /// <summary>
        /// Evaluates a binary operator over a pair index of fixed types
        /// </summary>
        /// <param name="api">The api member</param>
        /// <param name="src">The source pairs over which to evaluate the operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        public Triples<F> EvalFixed<F>(in MemberCode api, K.BinaryOpClass op, in Pairs<F> src)
            where F : unmanaged, IFixed
        {
            var count = src.Count;
            //var f = buffers[Left].EmitBinaryOp<F>(api);
            var f = Dynamic.EmitBinaryOp<F>(buffers[Left], api);
            var dst = Tuples.triples<F>(src.Count);
            for(var i=0; i<count; i++)
            {
                ref readonly var pair = ref src[i];
                dst[i] =  Tuples.triple(pair.Left, pair.Right, f(pair.Left,pair.Right));
            }
            return dst;
        }
    }
}