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
        public static IAsmImmCapture<T> Create(IAsmContext context, IVUnaryImm8Resolver128<T> resolver)
            => new AsmV128ImmUnaryCapture<T>(context, resolver);

        readonly IVUnaryImm8Resolver128<T> Resolver;

        readonly IAsmContext Context;

        [MethodImpl(Inline)]
        AsmV128ImmUnaryCapture(IAsmContext context, IVUnaryImm8Resolver128<T> resolver)
        {
            this.Resolver = resolver;
            this.Context = context;

        }
        
        public AsmFunction Capture(byte imm8)
        {
            var moniker = Resolver.Moniker;
            var f = Resolver.@delegate(imm8);
            var buffer = new byte[NativeServices.DefaultBufferLen];
            return Context.Decoder().DecodeFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }
    }

    readonly struct AsmV256ImmUnaryCapture<T> : IAsmImmCapture<T>
        where T : unmanaged
    {
        readonly IAsmContext Context;

        readonly IVUnaryImm8Resolver256<T> Resolver;

        [MethodImpl(Inline)]
        public static IAsmImmCapture<T> Create(IAsmContext context, IVUnaryImm8Resolver256<T> resolver)
            => new AsmV256ImmUnaryCapture<T>(context,resolver);


        [MethodImpl(Inline)]
        AsmV256ImmUnaryCapture(IAsmContext context, IVUnaryImm8Resolver256<T> resolver)
        {
            this.Resolver = resolver;
            this.Context = context;
        }

        public AsmFunction Capture(byte imm8)
        {
            var moniker = Resolver.Moniker;
            var f = Resolver.@delegate(imm8);
            var buffer = new byte[NativeServices.DefaultBufferLen];
            return Context.Decoder().DecodeFunction(NativeReader.read(moniker.WithImm(imm8), f, buffer));
        }
    }
}