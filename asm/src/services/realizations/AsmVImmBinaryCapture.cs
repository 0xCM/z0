//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Z0.AsmSpecs;
    
    using static zfunc;

    readonly struct AsmV128ImmBinaryCapture<T> : IAsmImmCapture<T>
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public static IAsmImmCapture<T> Create(IAsmContext context, IVBinaryImm8Resolver128<T> resolver)
            => new AsmV128ImmBinaryCapture<T>(context, resolver);

        readonly IAsmContext Context;

        readonly IVBinaryImm8Resolver128<T> Resolver;


        [MethodImpl(Inline)]
        AsmV128ImmBinaryCapture(IAsmContext context, IVBinaryImm8Resolver128<T> resolver)
        {
            this.Context = context;        
            this.Resolver = resolver;
        }
        
        public AsmFunction Capture(byte imm8)
        {
            var moniker = Resolver.Moniker;
            var f = Resolver.@delegate(imm8);
            var buffer = new byte[NativeReader.DefaultBufferLen];
            var decoder = AsmServices.Decoder();
            return decoder.DecodeFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }
    }

    readonly struct AsmV256ImmBinaryCapture<T> : IAsmImmCapture<T>
        where T : unmanaged
    {
        readonly IVBinaryImm8Resolver256<T> Resolver;

        readonly IAsmContext Context;

        [MethodImpl(Inline)]
        public static IAsmImmCapture<T> Create(IAsmContext context, IVBinaryImm8Resolver256<T> resolver)
            => new AsmV256ImmBinaryCapture<T>(context, resolver);


        [MethodImpl(Inline)]
        AsmV256ImmBinaryCapture(IAsmContext context, IVBinaryImm8Resolver256<T> resolver)
        {
            this.Context = context;        
            this.Resolver = resolver;
        }

        public AsmFunction Capture(byte imm8)
        {
            var moniker = Resolver.Moniker;
            var f = Resolver.@delegate(imm8);
            var buffer = new byte[NativeReader.DefaultBufferLen];
            var decoder = AsmServices.Decoder();
            return decoder.DecodeFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }
    }
}