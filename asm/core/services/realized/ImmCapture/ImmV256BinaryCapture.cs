//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    class ImmV256BinaryCaptureService<T> : IImmBinaryCapture<T>
        where T : unmanaged
    {
        readonly ISVImm8BinaryResolver256Api<T> Resolver;

        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureService CaptureService;

        [MethodImpl(Inline)]
        public static IImmBinaryCapture<T> New(IContext context, ISVImm8BinaryResolver256Api<T> resolver, IAsmFunctionDecoder decoder)
            => new ImmV256BinaryCaptureService<T>(context, resolver, decoder);

        [MethodImpl(Inline)]
        ImmV256BinaryCaptureService(IContext context, ISVImm8BinaryResolver256Api<T> resolver, IAsmFunctionDecoder decoder)
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