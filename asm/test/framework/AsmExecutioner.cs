//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Validation
{
    using System;
    using System.Linq;
    using static OperatorClass;

    class AsmExecutioner : IAsmExecutioner
    {        
        public IAsmWorkflowContext Context {get;}

        readonly IAppMsgSink Sink;

        readonly IAsmExecutor Executor;

        public static IAsmExecutioner Create(IAsmWorkflowContext context, IAppMsgSink sink)
            => new AsmExecutioner(context,sink);

        AsmExecutioner(IAsmWorkflowContext context, IAppMsgSink sink)
        {
            this.Context = context;
            this.Sink = sink;
            this.Executor = AsmExecutor.Create(context);
        }

        public void Publish(AppMsg msg)
            => Sink.NotifyConsole(msg);

        public void Publish(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);


        public void CheckExecution(in BufferSeq buffers, ApiMemberCode[] api)
        {
            for(var i=0; i<api.Length; i++)
                CheckExecution(buffers, api[i]);

        }

        public void CheckExecution(in BufferSeq buffers, ApiMemberCode api)
        {
            var kind = api.Member.KindId;
            if(kind.IsSome())
            {
                var apiclass = api.Method.ClassifyOperator();
                switch(apiclass)
                {
                    case UnaryOp:

                    break;
                    
                    case BinaryOp:
                        ExecuteBinaryOp(buffers, api);
                    break;

                    case TernaryOp:

                    break;
                }
            }
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

        public void ExecuteBinaryOp(in BufferSeq buffers, in ApiMemberCode api)
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