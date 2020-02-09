//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    readonly struct AsmImmUnaryCapture : IAsmImmCapture
    {
        public IAsmContext Context {get;}
        
        readonly MethodInfo Method;

        readonly OpIdentity BaseId;

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        public static IAsmImmCapture Create(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new AsmImmUnaryCapture(context, src,baseid);

        [MethodImpl(Inline)]
        AsmImmUnaryCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
        {            
            this.Context = context;
            this.Method = method;
            this.BaseId = baseid;
            this.Decoder = context.Decoder(false);
        }

        public AsmFunction Capture(in CaptureExchange exchange, byte imm)
        {
            var op = DynopImm.UnaryOp(HK.vk(), Method, BaseId, imm);
            return Decoder.DecodeFunction(exchange, op.Id, op);
        }
    }

    readonly struct AsmImmBinaryCapture : IAsmImmCapture
    {
        public IAsmContext Context {get;}
        
        readonly MethodInfo Method;

        readonly OpIdentity BaseId;

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        public static IAsmImmCapture Create(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new AsmImmBinaryCapture(context, src,baseid);

        [MethodImpl(Inline)]
        AsmImmBinaryCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
        {            
            this.Context = context;
            this.Method = method;
            this.BaseId = baseid;
            this.Decoder = context.Decoder(false);
        }

        public AsmFunction Capture(in CaptureExchange exchange, byte imm)
        {
           var op = DynopImm.BinaryOp(HK.vk(), Method, BaseId, imm);
           return Decoder.DecodeFunction(exchange, op.Id, op);
        }
    }
}