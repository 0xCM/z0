//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;
    
    readonly struct ImmV128UnaryCaptureService<T> : IImmUnaryCapture<T>
        where T : unmanaged
    {
        public IAsmContext Context {get;}

        readonly ISVImm8UnaryResolver128Api<T> Resolver;


        [MethodImpl(Inline)]
        public static IImmUnaryCapture<T> New(IAsmContext context, ISVImm8UnaryResolver128Api<T> resolver)
            => new ImmV128UnaryCaptureService<T>(context, resolver);

        [MethodImpl(Inline)]
        ImmV128UnaryCaptureService(IAsmContext context, ISVImm8UnaryResolver128Api<T> resolver)
        {
            this.Resolver = resolver;
            this.Context = context;
        }
        
        [MethodImpl(Inline)]
        public AsmFunction Capture(in OpExtractExchange exchange, byte imm8)
            => Context.AsmFunctionDecoder()
                        .DecodeFunction(Context.Capture().Capture(exchange,Resolver.Id.WithImm8(imm8),Resolver.@delegate(imm8)));
    }

    readonly struct ImmV256UnaryCaptureService<T> : IImmUnaryCapture<T>
        where T : unmanaged
    {
        public IAsmContext Context {get;}

        readonly ISVImm8UnaryResolver256Api<T> Resolver;

        [MethodImpl(Inline)]
        public static IImmUnaryCapture<T> New(IAsmContext context, ISVImm8UnaryResolver256Api<T> resolver)
            => new ImmV256UnaryCaptureService<T>(context,resolver);

        [MethodImpl(Inline)]
        ImmV256UnaryCaptureService(IAsmContext context, ISVImm8UnaryResolver256Api<T> resolver)
        {
            this.Resolver = resolver;
            this.Context = context;
        }

        [MethodImpl(Inline)]
        public AsmFunction Capture(in OpExtractExchange exchange, byte imm8)
            => Context.AsmFunctionDecoder()
                        .DecodeFunction(Context.Capture().Capture(exchange, Resolver.Id.WithImm8(imm8), Resolver.@delegate(imm8)));
    }
}