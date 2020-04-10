//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    
    readonly struct ImmV128BinaryCaptureService<T> : IImmBinaryCapture<T>
        where T : unmanaged
    {
        readonly ISVImm8BinaryResolver128Api<T> Resolver;

        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureService CaptureService;

        [MethodImpl(Inline)]
        public static IImmBinaryCapture<T> New(IContext context, ISVImm8BinaryResolver128Api<T> resolver, IAsmFunctionDecoder decoder)
            => new ImmV128BinaryCaptureService<T>(context, resolver, decoder);

        [MethodImpl(Inline)]
        ImmV128BinaryCaptureService(IContext context, ISVImm8BinaryResolver128Api<T> resolver, IAsmFunctionDecoder decoder)
        {
            this.Resolver = resolver;
            this.Decoder = decoder;
            this.CaptureService = context.Capture();            
        }
        
        public AsmFunction Capture(in OpExtractExchange exchange, byte imm8)
            => Decoder.DecodeFunction(CaptureService.Capture(exchange, Resolver.Id.WithImm8(imm8), Resolver.@delegate(imm8)));
    } 
}