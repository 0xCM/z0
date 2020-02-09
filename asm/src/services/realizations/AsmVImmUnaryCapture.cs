//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;

    using static zfunc;

    readonly struct AsmV128ImmUnaryCapture<T> : IAsmImmUnaryCapture<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static IAsmImmUnaryCapture<T> Create(IAsmContext context, IVUnaryImm8Resolver128<T> resolver)
            => new AsmV128ImmUnaryCapture<T>(context, resolver);

        readonly IVUnaryImm8Resolver128<T> Resolver;

        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        AsmV128ImmUnaryCapture(IAsmContext context, IVUnaryImm8Resolver128<T> resolver)
        {
            this.Resolver = resolver;
            this.Context = context;

        }
        
        [MethodImpl(Inline)]
        public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
            => Context.Decoder(false).DecodeFunction(CaptureServices.Operations.Capture(exchange, Resolver.Moniker.WithImm8(imm8), Resolver.@delegate(imm8)));
    }

    readonly struct AsmV256ImmUnaryCapture<T> : IAsmImmUnaryCapture<T>
        where T : unmanaged
    {
        public IAsmContext Context {get;}

        readonly IVUnaryImm8Resolver256<T> Resolver;

        [MethodImpl(Inline)]
        public static IAsmImmUnaryCapture<T> Create(IAsmContext context, IVUnaryImm8Resolver256<T> resolver)
            => new AsmV256ImmUnaryCapture<T>(context,resolver);

        [MethodImpl(Inline)]
        AsmV256ImmUnaryCapture(IAsmContext context, IVUnaryImm8Resolver256<T> resolver)
        {
            this.Resolver = resolver;
            this.Context = context;
        }

        [MethodImpl(Inline)]
        public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
            => Context.Decoder(false).DecodeFunction(CaptureServices.Operations.Capture(exchange, Resolver.Moniker.WithImm8(imm8), Resolver.@delegate(imm8)));
    }
}