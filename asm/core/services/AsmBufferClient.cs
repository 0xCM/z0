//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct AsmBufferedClient : IAsmBufferClient
    {
        public IAsmContext Context {get;}

        readonly AsmBufferClient Client;

        [MethodImpl(Inline)]
        public static IAsmBufferClient New(IAsmContext context, AsmBufferClient client)
            => new AsmBufferedClient(context, client);
        
        [MethodImpl(Inline)]
        AsmBufferedClient(IAsmContext context, AsmBufferClient client)
        {
            this.Context = context;
            this.Client = client;
        }

        public void Execute(in AsmBuffers buffers)
        {
            Client(buffers);
        }
    }
}