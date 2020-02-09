//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public delegate void AsmBufferClient(in AsmBuffers buffers);

    public interface IAsmBufferedClient : IAsmService
    {
        void Execute(in AsmBuffers buffers);
    }

    readonly struct AsmBufferedClient : IAsmBufferedClient
    {
        public IAsmContext Context {get;}

        readonly AsmBufferClient Client;

        public static IAsmBufferedClient Create(IAsmContext context, AsmBufferClient client)
            => new AsmBufferedClient(context, client);
        
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