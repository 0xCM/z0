//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    class ImmV256UnaryCaptureService<T> : IImmUnaryCapture<T>
        where T : unmanaged
    {
        readonly ISVImm8UnaryResolver256Api<T> Resolver;

        readonly ICaptureService CaptureService;

        readonly IAsmFunctionDecoder Decoder;

        [MethodImpl(Inline)]
        public static IImmUnaryCapture<T> New(IContext context, ISVImm8UnaryResolver256Api<T> resolver, IAsmFunctionDecoder decoder)
            => new ImmV256UnaryCaptureService<T>(context,resolver,decoder);

        [MethodImpl(Inline)]
        ImmV256UnaryCaptureService(IContext context, ISVImm8UnaryResolver256Api<T> resolver, IAsmFunctionDecoder decoder)
        {
            this.Resolver = resolver;
            this.Decoder = decoder;
            this.CaptureService = context.Capture();
        }

        [MethodImpl(Inline)]
        public Option<AsmFunction> Capture(in OpExtractExchange exchange, byte imm8)
                 => from c in CaptureService.Capture(exchange, Resolver.Id.WithImm8(imm8), Resolver.@delegate(imm8))
                from d in Decoder.DecodeCaptured(c)
                select d;
    }

}