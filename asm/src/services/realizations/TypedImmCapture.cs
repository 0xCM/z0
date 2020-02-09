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

    public static class TypedImmCapture
    {
        public static IAsmImmCapture<T> ImmCaptureService<T>(this IAsmContext context, IImm8Resolver<T> resolver)
            where T : unmanaged        
            => resolver switch {
                IVUnaryImm8Resolver128<T> r => AsmV128ImmUnaryCapture<T>.Create(context,r),
                IVUnaryImm8Resolver256<T> r => AsmV256ImmUnaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver128<T> r => AsmV128ImmBinaryCapture<T>.Create(context,r),
                IVBinaryImm8Resolver256<T> r => AsmV256ImmBinaryCapture<T>.Create(context,r),
                _ => throw unsupported(resolver.GetType())
            };   

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
        readonly struct AsmV128ImmBinaryCapture<T> : IAsmImmBinaryCapture<T>
            where T : unmanaged
        {
            public IAsmContext Context {get;}

            readonly IVBinaryImm8Resolver128<T> Resolver;

            [MethodImpl(Inline)]
            public static IAsmImmBinaryCapture<T> Create(IAsmContext context, IVBinaryImm8Resolver128<T> resolver)
                => new AsmV128ImmBinaryCapture<T>(context, resolver);

            [MethodImpl(Inline)]
            AsmV128ImmBinaryCapture(IAsmContext context, IVBinaryImm8Resolver128<T> resolver)
            {
                this.Context = context;        
                this.Resolver = resolver;
            }
            
            public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
                => Context.Decoder(false).DecodeFunction(CaptureServices.Operations.Capture(exchange, Resolver.Moniker.WithImm8(imm8), Resolver.@delegate(imm8)));
        }

        readonly struct AsmV256ImmBinaryCapture<T> : IAsmImmBinaryCapture<T>
            where T : unmanaged
        {
            public IAsmContext Context {get;}

            readonly IVBinaryImm8Resolver256<T> Resolver;

            [MethodImpl(Inline)]
            public static IAsmImmBinaryCapture<T> Create(IAsmContext context, IVBinaryImm8Resolver256<T> resolver)
                => new AsmV256ImmBinaryCapture<T>(context, resolver);

            [MethodImpl(Inline)]
            AsmV256ImmBinaryCapture(IAsmContext context, IVBinaryImm8Resolver256<T> resolver)
            {
                this.Context = context;        
                this.Resolver = resolver;
            }

            [MethodImpl(Inline)]
            public AsmFunction Capture(in CaptureExchange exchange, byte imm8)
                => Context.Decoder(false).DecodeFunction(CaptureServices.Operations.Capture(exchange, Resolver.Moniker.WithImm8(imm8), Resolver.@delegate(imm8)));
        }
    }
}