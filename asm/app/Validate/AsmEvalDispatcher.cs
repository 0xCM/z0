//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;

    using C = OperationClasses;
    using R = OperationClassReps;
    
    using static Nats;
    
    class AsmEvalDispatcher : IAsmEvalDispatcher
    {        
        public IAsmContext Context {get;}

        readonly IAppMsgSink Sink;

        readonly IPolyrand Random;
        
        readonly IAsmExecutor Executor;
        
        
        public static IAsmEvalDispatcher Create(IAsmContext context, IAppMsgSink sink)
            => new AsmEvalDispatcher(context,sink);

        AsmEvalDispatcher(IAsmContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.Sink = sink;
            this.Executor = AsmExecutor.Create(context);
            this.Random = context.Random;
        }

        AsmEvaluator Evaluator(in BufferSeq buffers)
            => AsmEvaluator.Create(Context, buffers);

        public void Notify(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public void Notify(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);

        public bit EvalFixedOperators(in BufferSeq buffers, ApiMemberCode[] api)
        {
            for(var i=0; i<api.Length; i++)
                EvalFixedOperator(buffers, api[i]);
            return 0;
        }

        public bit EvalFixedOperator(in BufferSeq buffers, in ApiMemberCode api)
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
                        return Dispatch(buffers, Random.FixedPairs<Fixed8>(count,n2), api);                    
                    case NumericKind.I8:
                        return 0;                            
                    case NumericKind.I16:
                        return 0;                            
                    case NumericKind.U16:
                        return 0;                            
                    case NumericKind.I32:
                        return 0;
                    case NumericKind.U32:
                        return 0;
                    case NumericKind.I64:
                        return 0;
                    case NumericKind.U64:
                        return 0;
                    default:
                        return 0;
                }

                default:
                    return 0;
            }
        }

        
       void Analyze<T>(in ApiMemberCode api, in BinaryEval<T> eval)
            where T : unmanaged
        {
            var name = api.Member.Id.Name;
            var sample = 0;
            var sampleMax = 10;

            Context.AnalyzingEvaluation(api);

            var xLabel = eval.LeftLabel;                
            var yLabel = eval.RightLabel;

            for(var i=0; i<eval.Count; i++, sample++)
            {
                ref readonly var input = ref eval.Source[i];
                ref readonly var result = ref eval.Target;
                var x = result.Target[i].Left;
                var y = result.Target[i].Right;
                Claim.eq(x, y);
            }
        }

        public void Dispatch(in BufferSeq buffers, in ApiMemberCode api, C.BinaryOp k)
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
                        Analyze(api,Context.Evaluate(buffers, api, k.As<byte>()));
                        break;
                    case NumericKind.I8:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<sbyte>()));
                        break;
                    case NumericKind.I16:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<short>()));
                        break;
                    case NumericKind.U16:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<ushort>()));
                        break;
                    case NumericKind.I32:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<int>()));
                        break;
                    case NumericKind.U32:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<uint>()));
                        break;
                    case NumericKind.I64:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<long>()));
                        break;
                    case NumericKind.U64:
                        Analyze(api,Context.Evaluate(buffers, api, k.As<ulong>()));
                        break;
                    default:
                        break;
                } 
            }
            catch(Exception e)
            {
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
        FixedBinaryOp<F> LoadFixedinaryOp<F>(in BufferSeq buffers, int index, ApiMemberCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedBinaryOp<F>(src);

        /// <summary>
        /// Loads and invokes a fixed binary operator
        /// </summary>
        /// <param name="buffers">The target buffer sequence</param>
        /// <param name="index">The index of the target buffer</param>
        /// <param name="src">The executable source that conforms to a fixed binary operator</param>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <typeparam name="F">The operand type</typeparam>
        F ExecBinaryOp<F>(in BufferSeq buffers, int index, ApiMemberCode src, F x, F y)
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

        bit Dispatch(in BufferSeq buffers, in Pairs<byte> src, in ApiMemberCode api)
        {

            var dst = Evaluator(buffers).Eval(api, R.BinaryOp, src);
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

        bit Dispatch(in BufferSeq buffers, in Pairs<Fixed8> src, in ApiMemberCode api)
        {

            var dst = Evaluator(buffers).EvalFixed(api, R.BinaryOp, src);
            Analyze(src, dst, api);
            return 1;
        }

        void Analyze<T>(in Pairs<T> src, in Triples<T> dst, in ApiMemberCode api)
            where T : unmanaged
        
        {

        }

        Triples<T> Dispatch<E,T>(in BufferSeq buffers, in ApiMemberCode api, IOperationClass<E,T> k, in Pairs<T> src)
            where E : unmanaged, Enum
            where T : unmanaged
        {        
            
            var evaluator = Context.Evaluator0(buffers, k);
            var dst = evaluator.Eval(api, R.BinaryOp, src);
            Analyze(src, dst, api);
            return dst;
        }
    }
}