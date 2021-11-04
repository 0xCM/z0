//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static BufferSeqId;

    [ApiHost]
    public readonly partial struct Evaluate
    {
        [MethodImpl(Inline), Op]
        public static IEvalDispatcher dispatcher(IWfRuntime wf, IBoundSource source, uint bufferSize)
            => new EvalDispatcher(wf, source, bufferSize);

        [MethodImpl(Inline), Op]
        public static IEvalExecutor executor(IWfRuntime wf, IBoundSource source)
            => new EvalExecutor(wf, source);

        public static ref readonly UnaryEvaluations<T> compute<T>(in UnaryEvalContext<T> exchange, Action<Exception> error)
            where T : unmanaged
        {
            @try(exchange, error);
            return ref exchange.Target;
        }

        public static ref readonly BinaryEvaluations<T> compute<T>(in BinaryEvalContext<T> exchange, Action<Exception> error)
            where T : unmanaged
        {
            @try(exchange, error);
            return ref exchange.Target;
        }

        static void @try<T>(in UnaryEvalContext<T> exchange, Action<Exception> handler)
            where T : unmanaged
        {
            try
            {
                var buffer = exchange.Buffers[Left];
                var code = exchange.ApiCode;

                if(!CheckBufferSize(code, buffer, out var msg))
                    term.print(msg);

                var f = exchange.Member.Method.CreateDelegate<UnaryOp<T>>();
                var g = DFx.unaryop<T>(buffer, code.Encoded);
                var reps = exchange.PointCount;
                for(var i=0; i<reps; i++)
                {
                    ref readonly var x = ref exchange.Input[i];
                    exchange.Outcomes[i] = (f(x), g(x));
                }

            }
            catch(Exception e)
            {
                handler(e);
            }
        }

        static void @try<T>(in BinaryEvalContext<T> exchange, Action<Exception> handler)
            where T : unmanaged
        {
            try
            {
                var buffer = exchange.Buffers[Left];
                var code = exchange.ApiCode;

                if(!CheckBufferSize(code, buffer, out var msg))
                    term.print(msg);

                var f = exchange.Member.Method.CreateDelegate<BinaryOp<T>>();
                var g = DFx.binaryop<T>(buffer, code.Encoded);
                var reps = exchange.PointCount;
                for(var i=0; i<reps; i++)
                {
                    ref readonly var pair = ref exchange.Input[i];
                    ref readonly var x = ref pair.Left;
                    ref readonly var y = ref pair.Right;
                    exchange.Outcomes[i] = (f(x,y), g(x, y));
                }

            }
            catch(Exception e)
            {
                handler(e);
            }
        }

        static bool CheckBufferSize(ApiMemberCode code, BufferToken buffer, out AppMsg msg)
        {
            if(buffer.BufferSize < code.Encoded.Length)
            {
                msg = Msg.BufferSizeError(code,buffer);
                return false;
            }
            else
            {
                msg = AppMsg.colorize("Nothing there", FlairKind.Disposed);
                return true;
            }
        }
    }

    public static partial class XTend
    {
        public static IEvalDispatcher EvalDispatcher(this IWfRuntime wf, IBoundSource source = null, uint? buffersize = null)
            => Evaluate.dispatcher(wf, source ?? Rng.@default(), buffersize ?? Pow2.T14);
    }
}