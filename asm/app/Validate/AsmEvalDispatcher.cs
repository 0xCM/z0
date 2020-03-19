//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;

    using static Root;
    using static Nats;

    using static OperatorClass;
    using Reps = OpClassReps;
    
    class AsmEvalDispatcher : IAsmEvalDispatcher
    {        
        public IAsmWorkflowContext Context {get;}

        readonly IAppMsgSink Sink;

        readonly IPolyrand Random;
        
        readonly IAsmExecutor Executor;
        
        public static IAsmEvalDispatcher Create(IAsmWorkflowContext context, IAppMsgSink sink)
            => new AsmEvalDispatcher(context,sink);

        AsmEvalDispatcher(IAsmWorkflowContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.Sink = sink;
            this.Executor = AsmExecutor.Create(context);
            this.Random = context.Random;
        }

        AsmEvaluator Evaluator(in BufferSeq buffers)
            => AsmEvaluator.Create(Context, buffers);

        public void Publish(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public void Publish(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);

        public bit EvalOperators(in BufferSeq buffers, ApiMemberCode[] api)
        {
            for(var i=0; i<api.Length; i++)
                EvalOperator(buffers, api[i]);
            return 0;
        }

        public bit EvalOperator(in BufferSeq buffers, ApiMemberCode api)
        {
            var kid = api.Member.KindId;
            int count = 128;
            if(kid == OpKindId.Div || kid == OpKindId.Mod)
                return 0;

            var nk = api.Method.ReturnType.NumericKind();

            if(kid.IsSome())
            {
                var apiclass = api.Method.ClassifyOperator();
                switch(apiclass)
                {
                    case UnaryOp:

                    break;
                    
                    case BinaryOp:
                    {
                        switch(nk)
                        {
                            case NumericKind.U8:
                                return Dispatch(buffers, Random.Pairs<byte>(count), api);
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
                    }

                    case TernaryOp:
                        return 0;                    
                }
            }
            return 0;
        }

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

        void Analyze(in Points<N2,byte> src, in Points<N3,byte> dst, in ApiMemberCode api)
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

        void Analyze(in Points<N2,ushort> src, in Points<N3,ushort> dst, in ApiMemberCode api)
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

            var dst = Evaluator(buffers).Eval(api, Reps.BinaryOp, src);
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

        void Analyze(in Points<N2,Fixed16> src, in Points<N3,Fixed16> dst, in ApiMemberCode api)
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

            var dst = Evaluator(buffers).EvalFixed(api, Reps.BinaryOp, src);
            Analyze(src, dst, api);
            return 1;
        }


        void Analyze<T>(in Pairs<T> src, in Triples<T> dst, in ApiMemberCode api)
            where T : unmanaged
        
        {

        }

        Triples<T> Dispatch<E,T>(in BufferSeq buffers, in ApiMemberCode api, IOpClass<E,T> k, in Pairs<T> src)
            where E : unmanaged, Enum
            where T : unmanaged
        {        
            
            var evaluator = Context.Evaluator0(buffers, k);
            var dst = evaluator.Eval(api, Reps.BinaryOp, src);
            Analyze(src, dst, api);
            return dst;
        }
    }
}