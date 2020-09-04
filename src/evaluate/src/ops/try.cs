//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static BufferSeqId;

    partial struct Evaluate
    {
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
                var g = GenericDynamic.unary<T>(buffer, code.Encoded);
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
                var g = GenericDynamic.binary<T>(buffer, code.Encoded);
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

        static bool CheckBufferSize(X86ApiMember code, BufferToken buffer, out AppMsg msg)
        {
            if(buffer.BufferSize < code.Encoded.Length)
            {
                msg = EvalMessages.BufferSizeError(code,buffer);
                return false;
            }
            else
            {
                msg = AppMsg.colorize("Nothing there", FlairKind.Disposed);
                return true;
            }
        }

        static IDynexus Dynamic => Dynops.Services.Dynexus;
    }
}