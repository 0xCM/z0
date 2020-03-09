//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    
    using static Root;
    using static Nats;
    using static FKT;
    
    readonly struct ImmV128UnaryCaptureService<T> : IImmUnaryCapture<T>
        where T : unmanaged
    {
        public IAsmContext Context {get;}

        readonly IImm8V128UnaryResolver<T> Resolver;


        [MethodImpl(Inline)]
        public static IImmUnaryCapture<T> New(IAsmContext context, IImm8V128UnaryResolver<T> resolver)
            => new ImmV128UnaryCaptureService<T>(context, resolver);

        [MethodImpl(Inline)]
        ImmV128UnaryCaptureService(IAsmContext context, IImm8V128UnaryResolver<T> resolver)
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

        readonly IImm8V256UnaryResolver<T> Resolver;

        [MethodImpl(Inline)]
        public static IImmUnaryCapture<T> New(IAsmContext context, IImm8V256UnaryResolver<T> resolver)
            => new ImmV256UnaryCaptureService<T>(context,resolver);

        [MethodImpl(Inline)]
        ImmV256UnaryCaptureService(IAsmContext context, IImm8V256UnaryResolver<T> resolver)
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