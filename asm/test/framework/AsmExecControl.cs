//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;

    using static Root;
    using static Nats;

    using static OperatorClass;


    class AsmExecControl : IAsmExecControl
    {        
        public IAsmWorkflowContext Context {get;}

        readonly IAppMsgSink Sink;

        readonly IPolyrand Random;
        readonly IAsmExecutor Executor;

        public static IAsmExecControl Create(IAsmWorkflowContext context, IAppMsgSink sink)
            => new AsmExecControl(context,sink);

        AsmExecControl(IAsmWorkflowContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.Sink = sink;
            this.Executor = AsmExecutor.Create(context);
            this.Random = context.Random;
        }

        public void Publish(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public void Publish(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);


        public bit EvalBinaryOp(in BufferSeq buffers, ApiMemberCode[] api)
        {
            for(var i=0; i<api.Length; i++)
                EvalBinaryOp(buffers, api[i]);
            return 0;
        }

        
        void Analyze(in FixedTripleIndex<Fixed8> outcome, in ApiMemberCode api)
        {

        }

        void Analyze(in FixedTripleIndex<Fixed16> outcome, in ApiMemberCode api)
        {

        }

        void Analyze(in FixedTripleIndex<Fixed32> outcome, in ApiMemberCode api)
        {
            for(var i=0; i< 10; i++)
            {
                (var a, var b, var c) = outcome[i];
                Sink.EvaluatedPoint(api.Member.KindId.Format(),a,b,c);
            }
        }

        void Analyze(in FixedTripleIndex<Fixed64> outcome, in ApiMemberCode api)
        {

        }

        void Analyze(in HomPoints<N2,byte> src, in HomPoints<N3,byte> dst, in ApiMemberCode api)
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

        bit EvalOperator(in BufferSeq buffers, in HomPoints<N2,byte> src, in ApiMemberCode api)
        {
            var dst = Executor.EvaluateOperator(buffers, api, src);
            Analyze(src, dst, api);
            return 1;
        }

        public bit EvalBinaryOp(in BufferSeq buffers, ApiMemberCode api)
        {
            var kid = api.Member.KindId;
            int count = 128;
            if(kid == OpKindId.Div || kid == OpKindId.Mod)
            {
                return 0;
            }
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
                                return EvalOperator(buffers, Random.HomPointIndex(count,n2,z8), api);
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

        public bit EvalFixedBinaryOp(in BufferSeq buffers, in ApiMemberCode api)
        {
            Sink.ValidatingOperator(api.Uri, BinaryOp);

            var nk = api.Method.ReturnType.NumericKind();
            var kid = api.Member.KindId;
            if(kid == OpKindId.Div || kid == OpKindId.Mod)
            {
                return 0;
            }

            var count = 128;

            switch(nk)
            {
                case NumericKind.U8:
                    return EvalOperator(buffers, Random.HomPointIndex(count,n2,z8), api);
                case NumericKind.I8:
                    var cases = Random.LoadPointSpanEmitter(count,(z8,z8,z8));
                    Analyze(Executor.ExecBinaryOp<Fixed8>(buffers, api, count), api);
                    break;
                case NumericKind.I16:
                case NumericKind.U16:
                    Analyze(Executor.ExecBinaryOp<Fixed16>(buffers, api, count),api);
                    break;
                case NumericKind.I32:
                case NumericKind.U32:
                    Analyze(Executor.ExecBinaryOp<Fixed32>(buffers, api, count),api);
                    break;
                case NumericKind.I64:
                case NumericKind.U64:
                    Analyze(Executor.ExecBinaryOp<Fixed64>(buffers, api, count),api);
                    break;
            }
            return 0;
        }

        public void ExecBinaryOp(in BufferSeq buffers, in ApiMemberCode api)
        {
            Sink.ValidatingOperator(api.Uri, BinaryOp);

            var nk = api.Method.ReturnType.NumericKind();
            var kid = api.Member.KindId;
            if(kid == OpKindId.Div || kid == OpKindId.Mod)
            {
                return;
            }

            var count = 128;
            switch(nk)
            {
                case NumericKind.U8:
                case NumericKind.I8:
                    var cases = Random.LoadPointSpanEmitter(count,(z8,z8,z8));
                    Analyze(Executor.ExecBinaryOp<Fixed8>(buffers, api, count), api);
                    break;
                case NumericKind.I16:
                case NumericKind.U16:
                    Analyze(Executor.ExecBinaryOp<Fixed16>(buffers, api, count),api);
                    break;
                case NumericKind.I32:
                case NumericKind.U32:
                    Analyze(Executor.ExecBinaryOp<Fixed32>(buffers, api, count),api);
                    break;
                case NumericKind.I64:
                case NumericKind.U64:
                    Analyze(Executor.ExecBinaryOp<Fixed64>(buffers, api, count),api);
                    break;
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
        public FixedBinaryOp<F> LoadBinaryOp<F>(in BufferSeq buffers, int index, ApiMemberCode src)
            where F : unmanaged, IFixed
                => buffers[index].LoadFixedBinaryOp<F>(src);

        /// <summary>
        /// Loads and invokes a fixed binary operator
        /// </summary>
        /// <param name="buffers">The target buffer sequence</param>
        /// <param name="index">The index of the target buffer</param>
        /// <param name="src">The executable source that conforms to a fixed binary operator</param>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <typeparam name="F">The operand type</typeparam>
        public F ExecBinaryOp<F>(in BufferSeq buffers, int index, ApiMemberCode src, F x, F y)
            where F : unmanaged, IFixed
                => LoadBinaryOp<F>(buffers, index, src)(x,y);
    }
}