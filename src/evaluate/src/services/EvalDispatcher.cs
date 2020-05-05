//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;


    using K = Kinds;

    class EvalDispatcher : IEvalDispatcher
    {        
        readonly IPolyrand Random;

        readonly IAppMsgSink Sink;
                                
        [MethodImpl(Inline)]
        public static IEvalDispatcher Create(IPolyrand random, IAppMsgSink sink)
            => new EvalDispatcher(random, sink);

        [MethodImpl(Inline)]
        internal EvalDispatcher(IPolyrand random, IAppMsgSink sink)
        {
            this.Random = random;
            this.Sink = sink;
        }

        MemberEvaluator Evaluator(BufferTokens buffers)
            => MemberEvaluator.Create(buffers);

        ICheckNumeric Numeric => CheckNumeric.Checker;

        const int EvalCount = 100;
        
        UnaryEval<T> eval<T>(BufferTokens buffers, in ApiMemberCode code,  K.UnaryOpClass<T> k)
            where T : unmanaged
        {
            var src = Random.Array<T>(EvalCount);
            var target =  Evaluations.pairs(("method", "asm"), Tuples.index(new Pair<T>[EvalCount]));
            var count = src.Length;
            var content = Evaluations.unary(src, target);
            var package = new UnaryOpEval<T>(EvalContext.Define(buffers, code), content);
            var evaluator = new UnaryOpEvaluator<T>();
            return evaluator.Evaluate(package);
        }

        BinaryEval<T> eval<T>(BufferTokens buffers, in ApiMemberCode code,  K.BinaryOpClass<T> k)
            where T : unmanaged
        {
            var src = Random.Pairs<T>(EvalCount);
            var count = src.Count;
            var target =  Evaluations.pairs(("method", "asm"), Tuples.index(new Pair<T>[EvalCount]));
            var content = Evaluations.binary(src, target);
            var package = new BinaryOpEval<T>(EvalContext.Define(buffers, code), content);
            var evaluator = new BinaryOpEvaluator<T>();
            return evaluator.Evaluate(package);
        }

        MemberEvaluator Evaluator<E,T>(BufferTokens buffers, IOpClass<E,T> k)
            where T : unmanaged
            where E : unmanaged, Enum
                => Evaluator(buffers);

        public void Notify(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public bit EvalFixedOperators(BufferTokens buffers, ApiMemberCode[] api)
        {
            for(var i=0; i<api.Length; i++)
                EvalFixedOperator(buffers, api[i]);
            return 0;
        }

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public Pairs<F> FixedPairs<F>(int count, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = Random.FixedStream<F>().Take(count);
            var s2 = Random.FixedStream<F>().Take(count);
            return s1.Zip(s2).Select(a =>  Tuples.pair(a.First, a.Second)).ToArray();
        }

        public bit EvalFixedOperator(BufferTokens buffers, in ApiMemberCode api)
        {
            var nk = api.Method.ReturnType.NumericKind();
            var kid = api.Member.KindId;
            var count = 128;
            var n = n2;

            if(kid == OpKindId.Div || kid == OpKindId.Mod)
                return 0;

            var apiclass = api.Method.ClassifyOperator();
            switch(apiclass)
            {
                case OperatorClass.BinaryOp:
                switch(nk)
                {
                    case NumericKind.U8:
                    case NumericKind.I8:
                        return Dispatch(buffers, FixedPairs<Fixed8>(count), api);                    
                    case NumericKind.I16:
                    case NumericKind.U16:
                        return Dispatch(buffers, FixedPairs<Fixed16>(count), api);                    
                    case NumericKind.I32:
                    case NumericKind.U32:
                        return 0;
                    case NumericKind.I64:
                    case NumericKind.U64:
                        return 0;
                    default:
                        return 0;
                }

                default:
                    return 0;
            }
        }

        HashSet<OpKindId> EvalSkip {get;}
            = new HashSet<OpKindId>(seq(OpKindId.Inc));

        void Analyze<T>(in ApiMemberCode api, in UnaryEval<T> eval)
            where T : unmanaged
        {
            if(EvalSkip.Contains(api.KindId))
                return;

            var name = api.Member.Id.Name;
            var sample = 0;
            var sampleMax = 10;
            var fp = typeof(T).IsFloatingPoint();

            Sink.AnalyzingEvaluation(api);

            var xLabel = eval.LeftLabel;                
            var yLabel = eval.RightLabel;

            for(var i=0; i<eval.Count; i++, sample++)
            {
                ref readonly var input = ref eval.Source[i];
                ref readonly var result = ref eval.Target;
                
                var x = result.Target[i].Left;
                var y = result.Target[i].Right;                
                
                if(fp)
                    Numeric.close(x,y);
                else
                    Numeric.eq(x,y);
            }
        }

       void Analyze<T>(in ApiMemberCode api, in BinaryEval<T> eval)
            where T : unmanaged
        {
            if(EvalSkip.Contains(api.KindId))
                return;

            var name = api.Member.Id.Name;
            var sample = 0;
            var sampleMax = 10;
            var fp = typeof(T).IsFloatingPoint();

            Sink.AnalyzingEvaluation(api);

            var xLabel = eval.LeftLabel;                
            var yLabel = eval.RightLabel;

            for(var i=0; i<eval.Count; i++, sample++)
            {
                ref readonly var input = ref eval.Source[i];
                ref readonly var result = ref eval.Target;
                var x = result.Target[i].Left;
                var y = result.Target[i].Right;
                if(fp)
                    Numeric.close(x,y);
                else
                    Numeric.eq(x,y);
            }
        }

        public void Dispatch(BufferTokens buffers, in ApiMemberCode api, K.UnaryOpClass k)
        {
            var kid = api.Member.KindId;
            int count = 128;
            if(kid == 0 || kid == OpKindId.Div || kid == OpKindId.Mod)
                return;

            var nk = api.Method.ReturnType.NumericKind();
            try
            {
                switch(nk)
                {
                    case NumericKind.U8:
                        Analyze(api, eval(buffers, api, k.As<byte>()));
                        break;
                    case NumericKind.I8:
                        Analyze(api, eval(buffers, api, k.As<sbyte>()));
                        break;
                    case NumericKind.I16:
                        Analyze(api, eval(buffers, api, k.As<short>()));
                        break;
                    case NumericKind.U16:
                        Analyze(api, eval(buffers, api, k.As<ushort>()));
                        break;
                    case NumericKind.I32:
                        Analyze(api, eval(buffers, api, k.As<int>()));
                        break;
                    case NumericKind.U32:
                        Analyze(api, eval(buffers, api, k.As<uint>()));
                        break;
                    case NumericKind.I64:
                        Analyze(api, eval(buffers, api, k.As<long>()));
                        break;
                    case NumericKind.U64:
                        Analyze(api, eval(buffers, api, k.As<ulong>()));
                        break;
                    case NumericKind.F32:
                        Analyze(api, eval(buffers, api, k.As<float>()));
                        break;
                    case NumericKind.F64:
                        Analyze(api, eval(buffers, api, k.As<double>()));
                        break;
                    default:
                        break;
                } 
            }
            catch(Exception e)
            {
                Notify(AppMsg.Error($"Failure evaluating operation {api.Id} of kind {kid}"));
                Notify(AppMsg.Error(e));
            }           
        }

        public void Dispatch(BufferTokens buffers, in ApiMemberCode api, K.BinaryOpClass k)
        {
            var kid = api.Member.KindId;
            int count = 128;
            if(kid == 0 || kid == OpKindId.Div || kid == OpKindId.Mod)
                return;

            var nk = api.Method.ReturnType.NumericKind();
            try
            {
                switch(nk)
                {
                    case NumericKind.U8:
                        Analyze(api, eval(buffers, api, k.As<byte>()));
                        break;
                    case NumericKind.I8:
                        Analyze(api, eval(buffers, api, k.As<sbyte>()));
                        break;
                    case NumericKind.I16:
                        Analyze(api, eval(buffers, api, k.As<short>()));
                        break;
                    case NumericKind.U16:
                        Analyze(api, eval(buffers, api, k.As<ushort>()));
                        break;
                    case NumericKind.I32:
                        Analyze(api, eval(buffers, api, k.As<int>()));
                        break;
                    case NumericKind.U32:
                        Analyze(api, eval(buffers, api, k.As<uint>()));
                        break;
                    case NumericKind.I64:
                        Analyze(api, eval(buffers, api, k.As<long>()));
                        break;
                    case NumericKind.U64:
                        Analyze(api, eval(buffers, api, k.As<ulong>()));
                        break;
                    case NumericKind.F32:
                        Analyze(api, eval(buffers, api, k.As<float>()));
                        break;
                    case NumericKind.F64:
                        Analyze(api, eval(buffers, api, k.As<double>()));
                        break;
                    default:
                        break;
                } 
            }
            catch(Exception e)
            {
                Notify(AppMsg.Error($"Failure evaluating operation {api.Id} of kind {kid}"));
                Notify(AppMsg.Error(e));
            }           
        }

        /// <summary>
        /// Loads executable code into an index-identifed target buffer and manufactures a fixed binary operator 
        /// that executes the code in the buffer upon invocation
        /// </summary>
        /// <param name="buffers">The target buffer sequence</param>
        /// <param name="index">The index of the target buffer</param>
        /// <param name="src">The executable source that conforms to a fixed binary operator</param>
        /// <typeparam name="F">The operand type</typeparam>
        FixedBinaryOp<F> LoadFixedinaryOp<F>(BufferTokens buffers, BufferSeqId index, ApiMemberCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedBinaryOp<F>(src.Encoded);

        /// <summary>
        /// Loads and invokes a fixed binary operator
        /// </summary>
        /// <param name="buffers">The target buffer sequence</param>
        /// <param name="index">The index of the target buffer</param>
        /// <param name="src">The executable source that conforms to a fixed binary operator</param>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <typeparam name="F">The operand type</typeparam>
        F ExecBinaryOp<F>(BufferTokens buffers, BufferSeqId index, ApiMemberCode src, F x, F y)
            where F : unmanaged, IFixed
                => LoadFixedinaryOp<F>(buffers, index, src)(x,y);

        void Analyze(in Pairs<byte> src, in Triples<byte> dst, in ApiMemberCode api)
        {
            for(var i=0; i< 10; i++)
            {
                ref readonly var eval = ref dst[i];
                var x0 = eval[n0];
                var x1 = eval[n1];
                var x2 = eval[n2];
                Sink.EvaluatedPoint(api.Member.KindId.Format(), x0,x1,x2);
            }
        }

        bit Dispatch(BufferTokens buffers, in Pairs<byte> src, in ApiMemberCode api)
        {

            var dst = Evaluator(buffers).Eval(api, K.BinaryOp, src);
            Analyze(src, dst, api);
            return 1;
        }

        void Analyze(in Pairs<Fixed8> src, in Triples<Fixed8> dst, in ApiMemberCode api)
        {
            for(var i=0; i< 10; i++)
            {
                ref readonly var eval = ref dst[i];
                var x0 = eval[n0];
                var x1 = eval[n1];
                var x2 = eval[n2];
                Sink.EvaluatedPoint(api.Member.KindId.Format(),x0,x1,x2);
            }
        }

        bit Dispatch(BufferTokens buffers, in Pairs<Fixed8> src, in ApiMemberCode api)
        {

            var dst = Evaluator(buffers).EvalFixed(api, K.BinaryOp, src);
            Analyze(src, dst, api);
            return 1;
        }

        bit Dispatch(BufferTokens buffers, in Pairs<Fixed16> src, in ApiMemberCode api)
        {

            var dst = Evaluator(buffers).EvalFixed(api, K.BinaryOp, src);
            Analyze(src, dst, api);
            return 1;
        }

        void Analyze<T>(in Pairs<T> src, in Triples<T> dst, in ApiMemberCode api)
            where T : unmanaged
        
        {

        }

        Triples<T> Dispatch<E,T>(BufferTokens buffers, in ApiMemberCode api, IOpClass<E,T> k, in Pairs<T> src)
            where E : unmanaged, Enum
            where T : unmanaged
        {        
            
            var evaluator = Evaluator(buffers, k);
            var dst = evaluator.Eval(api, K.BinaryOp, src);
            Analyze(src, dst, api);
            return dst;
        }
    }
}