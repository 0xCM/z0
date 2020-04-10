//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    class ImmUnaryCaptureService : IImmCapture
    {        
        readonly MethodInfo Method;

        readonly OpIdentity BaseId;

        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureService CaptureService;

        /// <summary>
        /// Instantiates a contextual immediate capture service for a unary operator
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="src">A unary operator that requires an immediate value</param>
        /// <param name="baseid">The identity to use as a basis for immediate-specialized identities</param>
        [MethodImpl(Inline)]
        public static IImmCapture Create(IContext context, MethodInfo src, OpIdentity baseid, IAsmFunctionDecoder decoder)
            => new ImmUnaryCaptureService(context, src,baseid,decoder);

        [MethodImpl(Inline)]
        public ImmUnaryCaptureService(IContext context, MethodInfo method, OpIdentity baseid, IAsmFunctionDecoder decoder)
        {            
            this.Method = method;
            this.BaseId = baseid;
            this.Decoder = decoder;
            this.CaptureService = context.Capture();
        }

        public Option<AsmFunction> Capture(in OpExtractExchange exchange, byte imm)
        {
            var op = Dynop.EmbedVUnaryOpImm(Method, imm, BaseId);
            return from c in CaptureService.Capture(exchange, op.Id, op)
                from d in Decoder.DecodeCaptured(c)
                select d;            
        }
    }
}