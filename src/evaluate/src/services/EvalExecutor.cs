//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;
    using static BufferSeqId;

    class EvalExecutor : IEvalExecutor
    {
        readonly IPolyStream Random;

        readonly int RepCount;

        EvalExecutorContext Context;

        [MethodImpl(Inline)]
        internal EvalExecutor(IPolyStream random)
        {
            RepCount = 128;
            Random = random;
            Context = Evaluate.context(random, 128);
        }

        public EvalResult MatchBinaryOps(in NativeBuffers buffers, CellWidth w, in ConstPair<ApiMemberCode> paired)
        {
            var clock = Time.counter();
            try
            {
                switch(w)
                {
                    case CellWidth.W8:
                        return MatchBinaryOps(buffers, n8, paired);

                    case CellWidth.W16:
                        return MatchBinaryOps(buffers, n16, paired);

                    case CellWidth.W32:
                        return MatchBinaryOps(buffers, n32, paired);

                    case CellWidth.W64:
                        return MatchBinaryOps(buffers, n64, paired);

                    case CellWidth.W128:
                        return MatchBinaryOps(buffers, n128, paired);

                    case CellWidth.W256:
                        return MatchBinaryOps(buffers, n256, paired);

                    default:
                        return Eval.result(seq, (paired.Left.Uri, paired.Right.Uri), clock, AppMsg.error($"Handler not found"));
                }
            }
            catch(Exception error)
            {
                return Eval.result(seq, (paired.Left.Uri, paired.Right.Uri), clock, error);
            }
        }

        EvalResult MatchBinaryOps(in NativeBuffers buffers, N8 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);
        }

        EvalResult MatchBinaryOps(in NativeBuffers buffers, N16 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);
        }

        EvalResult MatchBinaryOps(in NativeBuffers buffers, N32 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);
        }

        EvalResult MatchBinaryOps(in NativeBuffers buffers, N64 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);
        }

        EvalResult MatchBinaryOps(in NativeBuffers buffers, N128 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);
        }

        EvalResult MatchBinaryOps(in NativeBuffers buffers, N256 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left.Encoded);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right.Encoded);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public EvalResult CheckMatch(BinaryOp8 f, OpUri fUri, BinaryOp8 g, OpUri gUri)
            => Executor.validate(Context, f, fUri, g, gUri);

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public EvalResult CheckMatch(BinaryOp16 f, OpUri fUri, BinaryOp16 g, OpUri gUri)
        {
            var w = n16;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    Claim.Eq(f(x,y),g(x,y));
                }
            }

            return ExecAction(check, fUri, gUri);
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public EvalResult CheckMatch(BinaryOp32 f, OpUri fUri, BinaryOp32 g, OpUri gUri)
        {
            var w = n32;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    Claim.Eq(f(x,y),g(x,y));
                }
            }

            return ExecAction(check, fUri, gUri);
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public EvalResult CheckMatch(BinaryOp64 f, OpUri fUri, BinaryOp64 g, OpUri gUri)
        {
            var w = n64;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    Claim.Eq(f(x,y),g(x,y));
                }
            }

            return ExecAction(check, fUri, gUri);
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public EvalResult CheckMatch(BinaryOp128 f, OpUri fUri, BinaryOp128 g, OpUri gUri)
        {
            var w = n128;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    Claim.Eq(f(x,y),g(x,y));
                }
            }

            return ExecAction(check, fUri, gUri);
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        public EvalResult CheckMatch(BinaryOp256 f, OpUri fUri, BinaryOp256 g, OpUri gUri)
        {
            var w = n256;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    Claim.Eq(f(x,y),g(x,y));
                }
            }

            return ExecAction(check, fUri, gUri);
        }


        public EvalResult ExecAction(Action action, OpUri f, OpUri g)
        {

            var clock = Time.counter(true);
            try
            {
                action();
                return Eval.result(seq, (f,g), clock, true );
            }
            catch(Exception e)
            {
                return Eval.result(seq, (f,g), clock, e);
            }
        }

        static ICheckEquatable Claim => CheckEquatable.Checker;

        static int _checkseq;

        static int seq
        {
            [MethodImpl(Inline)]
            get => root.atomic(ref _checkseq);
        }
    }
}