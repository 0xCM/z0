//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    //using static time;
    using static Seed;
    using static Memories;
    using static BufferSeqId;

    class EvalExecutor : IEvalExecutor
    {
        readonly IPolyrand Random;

        readonly int RepCount;

        [MethodImpl(Inline)]
        public static IEvalExecutor Create(IContext context, IPolyrand random)
            => new EvalExecutor(context,random);

        [MethodImpl(Inline)]
        EvalExecutor(IContext context, IPolyrand random)
        {
            this.RepCount = 128;
            this.Random = random;
        }

        static int _checkseq;

        static int seq
        {
            [MethodImpl(Inline)]
            get => increment(ref _checkseq);
        }
        
        public EvalResult MatchBinaryOps(in BufferSeq buffers, FixedWidth w, in ConstPair<ApiMemberCode> paired)
        {
            var clock = time.counter();
            try
            {
                switch(w)
                {
                    case FixedWidth.W8:
                        return MatchBinaryOps(buffers, n8, paired);

                    case FixedWidth.W16:
                        return MatchBinaryOps(buffers, n16, paired);

                    case FixedWidth.W32:
                        return MatchBinaryOps(buffers, n32, paired);

                    case FixedWidth.W64:
                        return MatchBinaryOps(buffers, n64, paired);

                    case FixedWidth.W128:
                        return MatchBinaryOps(buffers, n128, paired);

                    case FixedWidth.W256:
                        return MatchBinaryOps(buffers, n256, paired);

                    default:
                        return EvalResult.Define(seq, (paired.Left.Uri, paired.Right.Uri), clock, AppMsg.Error($"Handler not found"));  
                }
            }
            catch(Exception error)
            {
                return EvalResult.Define(seq, (paired.Left.Uri, paired.Right.Uri), clock, error);  
            }
        }

        EvalResult MatchBinaryOps(in BufferSeq buffers, N8 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        EvalResult MatchBinaryOps(in BufferSeq buffers, N16 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        EvalResult MatchBinaryOps(in BufferSeq buffers, N32 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        EvalResult MatchBinaryOps(in BufferSeq buffers, N64 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        EvalResult MatchBinaryOps(in BufferSeq buffers, N128 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        EvalResult MatchBinaryOps(in BufferSeq buffers, N256 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
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
        {
            var w = n8;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
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
        public EvalResult CheckMatch(BinaryOp16 f, OpUri fUri, BinaryOp16 g, OpUri gUri)
        {
            var w = n16;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
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
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
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
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
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
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
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
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            return ExecAction(check, fUri, gUri);
        }

        public EvalResult ExecAction(Action action, OpUri f)
        {
            
            var clock = time.counter(true);
            try
            {
                action();
                return EvalResult.Define(seq, f, clock, true);
            }
            catch(Exception e)
            {
                return EvalResult.Define(seq, f, clock, e);
            }
        }

        public EvalResult ExecAction(Action action, OpUri f, OpUri g)
        {
            
            var clock = time.counter(true);
            try
            {
                action();
                return EvalResult.Define(seq, (f,g), clock, true );
            }
            catch(Exception e)
            {
                return EvalResult.Define(seq, (f,g), clock, e);
            }
        }
    }
}