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

    public static class AsmImmCapture
    {
        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IAsmImmCapture Unary(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new AsmImmUnaryCapture(context, src,baseid);

        /// <summary>
        /// Instantiates a contextual immediate capture service for a binary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IAsmImmCapture Binary(IAsmContext context, MethodInfo src, OpIdentity baseid)
            => new AsmImmBinaryCapture(context, src,baseid);

        static AsmFunction Decode(IAsmDecoder decoder, in CaptureExchange exchange, OpIdentity id, DynamicDelegate src)
            => decoder.DecodeFunction(CaptureServices.Operations.Capture(in exchange, id, src));

        readonly struct AsmImmUnaryCapture : IAsmImmCapture
        {
            public IAsmContext Context {get;}
            
            readonly MethodInfo Method;

            readonly OpIdentity BaseId;

            readonly IAsmDecoder Decoder;

            [MethodImpl(Inline)]
            public AsmImmUnaryCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
            {            
                this.Context = context;
                this.Method = method;
                this.BaseId = baseid;
                this.Decoder = context.Decoder(false);
            }

            public AsmFunction Capture(in CaptureExchange exchange, byte imm)
            {
                var op = Dynop.UnaryOpImm(VK.vk(), Method, BaseId, imm);
                return Decode(Decoder, exchange, op.Id, op);
            }
        }

        readonly struct AsmImmBinaryCapture : IAsmImmCapture
        {
            public IAsmContext Context {get;}
            
            readonly MethodInfo Method;

            readonly OpIdentity BaseId;

            readonly IAsmDecoder Decoder;

            [MethodImpl(Inline)]
            public AsmImmBinaryCapture(IAsmContext context, MethodInfo method, OpIdentity baseid)
            {            
                this.Context = context;
                this.Method = method;
                this.BaseId = baseid;
                this.Decoder = context.Decoder(false);
            }

            public AsmFunction Capture(in CaptureExchange exchange, byte imm)
            {
                var op = Dynop.BinaryOpImm(VK.vk(), Method, BaseId, imm);
                return Decode(Decoder, exchange, op.Id, op);
            }
        }
    }
}