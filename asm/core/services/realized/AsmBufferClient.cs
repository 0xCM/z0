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
        readonly AsmBufferClient Client;

        [MethodImpl(Inline)]
        public static IAsmBufferClient New(IContext context, AsmBufferClient client)
            => new AsmBufferedClient(client);
        
        [MethodImpl(Inline)]
        AsmBufferedClient(AsmBufferClient client)
        {
            this.Client = client;
        }

        public void Execute(in AsmBuffers buffers)
        {
            Client(buffers);
        }
    }
}