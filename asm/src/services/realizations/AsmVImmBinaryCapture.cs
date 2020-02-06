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
        
        public AsmFunction CaptureBinary(byte imm8)
        {
            var moniker = Resolver.Moniker;
            var f = Resolver.@delegate(imm8);
            var buffer = new byte[NativeServices.DefaultBufferLen];
            return Context.Decoder().DecodeFunction(NativeServices.MemberCapture().Capture(moniker.WithImm8(imm8), f, buffer));
        }
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

        public AsmFunction CaptureBinary(byte imm8)
        {
            var moniker = Resolver.Moniker;
            var f = Resolver.@delegate(imm8);
            var buffer = new byte[NativeServices.DefaultBufferLen];
            return Context.Decoder().DecodeFunction(NativeServices.MemberCapture().Capture(moniker.WithImm8(imm8), f, buffer));
        }
    }
}