//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static BufferSeqId;

    using K = Kinds;

    public readonly struct Executor
    {
        public static EvalResult<ExecutorContext> validate(ExecutorContext context, in BufferSeq buffers, BinaryOpClass k, N8 w, in ConstPair<X86ApiMember> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return validate(context, f, pair.Left.Uri, g, pair.Right.Uri);
        }

        static void check(ExecutorContext context, BinaryOp8 f, BinaryOp8 g)
        {
            var w = n8;
            for(var i=0; i <context.PointCount; i++)
            {
                var x = context.DataSource.Cell(w);
                var y = context.DataSource.Cell(w);
                Demands.insist(f(x,y),g(x,y));
            }
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public static EvalResult<ExecutorContext> validate(ExecutorContext context, BinaryOp8 f, OpUri fUri, BinaryOp8 g, OpUri gUri)
        {
            return exec(context, () => check(context, f, g), fUri, gUri);
        }

        public static EvalResult<ExecutorContext> exec(ExecutorContext context, Action action, OpUri f, OpUri g)
        {
            var clock = Time.counter(true);
            try
            {
                action();
                var outcome =  Evaluations.result(context.Sequence, (f,g), clock, true );
                return (outcome,context);
            }
            catch(Exception e)
            {
                var outcome = Evaluations.result(context.Sequence, (f,g), clock, e);
                return (outcome,context);
            }
        }
    }
}