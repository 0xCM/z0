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

    using static zfunc;

    using Z0.AsmSpecs;

    readonly struct AsmV128ImmUnaryCapture<T> : IAsmImmCapture<T>
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public static IAsmImmCapture<T> Create(IVUnaryImm8Resolver128<T> resolver)
            => new AsmV128ImmUnaryCapture<T>(resolver);

        readonly IVUnaryImm8Resolver128<T> Resolver;

        [MethodImpl(Inline)]
        AsmV128ImmUnaryCapture(IVUnaryImm8Resolver128<T> resolver)
        {
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

    readonly struct AsmV256ImmUnaryCapture<T> : IAsmImmCapture<T>
        where T : unmanaged
    {
        readonly IVUnaryImm8Resolver256<T> Resolver;

        [MethodImpl(Inline)]
        public static IAsmImmCapture<T> Create(IVUnaryImm8Resolver256<T> resolver)
            => new AsmV256ImmUnaryCapture<T>(resolver);


        [MethodImpl(Inline)]
        AsmV256ImmUnaryCapture(IVUnaryImm8Resolver256<T> resolver)
        {
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