//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;
    using static time;
    using static Nats;
    using static BufferSeqId;

    class AsmExecutor : IAsmExecutor
    {
        public IAsmContext Context {get;}
        
        [MethodImpl(Inline)]
        public static IAsmExecutor Create(IAsmContext context)
            => new AsmExecutor(context);

        [MethodImpl(Inline)]
        AsmExecutor(IAsmContext context)
        {
            this.Context = context;
            this.RepCount = 128;
        }

        IPolyrand Random => Context.Random;


        readonly int RepCount;

        static int _checkseq;

        static int seq
        {
            [MethodImpl(Inline)]
            get => increment(ref _checkseq);
        }
        
        public AsmExecResult MatchBinaryOps(in BufferSeq buffers, FixedWidth w, in ConstPair<ApiMemberCode> paired)
        {
            var clock = counter();
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
                        return AsmExecResult.Define(seq, (paired.Left.Uri, paired.Right.Uri), clock, AppMsg.Error($"Handler not found"));  
                }
            }
            catch(Exception error)
            {
                return AsmExecResult.Define(seq, (paired.Left.Uri, paired.Right.Uri), clock, error);  
            }
        }

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, N8 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, N16 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, N32 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, N64 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, N128 w, in ConstPair<ApiMemberCode> pair)
        {
            var f = buffers[Left].EmitFixedBinaryOp(w, pair.Left);
            var g = buffers[Right].EmitFixedBinaryOp(w, pair.Right);
            return CheckMatch(f, pair.Left.Uri, g, pair.Right.Uri);  
        }

        AsmExecResult MatchBinaryOps(in BufferSeq buffers, N256 w, in ConstPair<ApiMemberCode> pair)
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
        public AsmExecResult CheckMatch(BinaryOp8 f, OpUri fUri, BinaryOp8 g, OpUri gUri)
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
        public AsmExecResult CheckMatch(BinaryOp16 f, OpUri fUri, BinaryOp16 g, OpUri gUri)
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
        public AsmExecResult CheckMatch(BinaryOp32 f, OpUri fUri, BinaryOp32 g, OpUri gUri)
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
        public AsmExecResult CheckMatch(BinaryOp64 f, OpUri fUri, BinaryOp64 g, OpUri gUri)
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
        public AsmExecResult CheckMatch(BinaryOp128 f, OpUri fUri, BinaryOp128 g, OpUri gUri)
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
        public AsmExecResult CheckMatch(BinaryOp256 f, OpUri fUri, BinaryOp256 g, OpUri gUri)
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

        public AsmExecResult ExecAction(Action action, OpUri f)
        {
            
            var clock = counter(true);
            try
            {
                action();
                return AsmExecResult.Define(seq, f, clock, true);
            }
            catch(Exception e)
            {
                return AsmExecResult.Define(seq, f, clock, e);
            }
        }

        public AsmExecResult ExecAction(Action action, OpUri f, OpUri g)
        {
            
            var clock = counter(true);
            try
            {
                action();
                return AsmExecResult.Define(seq, (f,g), clock, true );
            }
            catch(Exception e)
            {
                return AsmExecResult.Define(seq, (f,g), clock, e);
            }
        }
    }
}