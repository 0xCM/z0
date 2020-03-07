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
    
    readonly struct ImmV128BinaryCaptureService<T> : IImmBinaryCapture<T>
        where T : unmanaged
    {
        public IAsmContext Context {get;}

        readonly IImm8V128BinaryResolver<T> Resolver;

        [MethodImpl(Inline)]
        public static IImmBinaryCapture<T> New(IAsmContext context, IImm8V128BinaryResolver<T> resolver)
            => new ImmV128BinaryCaptureService<T>(context, resolver);

        [MethodImpl(Inline)]
        ImmV128BinaryCaptureService(IAsmContext context, IImm8V128BinaryResolver<T> resolver)
        {
            this.Context = context;        
            this.Resolver = resolver;
        }
        
        public AsmFunction Capture(in OpExtractExchange exchange, byte imm8)
            => Context.AsmFunctionDecoder()
                        .DecodeFunction(
                            Context.Capture().Capture(
                                exchange,
                                Resolver.Id.WithImm8(imm8),
                                Resolver.@delegate(imm8)),
                                false);
    }

    readonly struct ImmV256BinaryCaptureService<T> : IImmBinaryCapture<T>
        where T : unmanaged
    {
        public IAsmContext Context {get;}

        readonly IImm8V256BinaryResolver<T> Resolver;

        [MethodImpl(Inline)]
        public static IImmBinaryCapture<T> New(IAsmContext context, IImm8V256BinaryResolver<T> resolver)
            => new ImmV256BinaryCaptureService<T>(context, resolver);

        [MethodImpl(Inline)]
        ImmV256BinaryCaptureService(IAsmContext context, IImm8V256BinaryResolver<T> resolver)
        {
            this.Context = context;        
            this.Resolver = resolver;
        }

        [MethodImpl(Inline)]
        public AsmFunction Capture(in OpExtractExchange exchange, byte imm8)
            => Context.AsmFunctionDecoder()
                        .DecodeFunction(
                            Context.Capture().Capture(
                                exchange,
                                Resolver.Id.WithImm8(imm8),
                                Resolver.@delegate(imm8)),
                                false);
    } 
 
}