//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
        
    public readonly partial struct MachineWorkflows : IDisposable
    {        
        readonly ActorIdentity[] Known;
        
        readonly EventBroker Broker;

        readonly IAppContext Context;

        readonly bool CaptureArtifacts;
        
        readonly string[] Args;

        internal MachineWorkflows(IAppContext context, params string[] args)
        {
            Args = args ?? sys.empty<string>();
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = sys.empty<ActorIdentity>();
            CaptureArtifacts = true;
            term.print($"Running machine worklfows");
        }
        
        public void Run()
        {
            using var capture = CaptureHost.ceate(Context, Args);
            capture.Run();            
            
            using var emission = new EmissionWorkflow(Context, Args);
            emission.Run();
        }

        public void Dispose()
        {
            Broker.Dispose();
            term.print($"Ran machine worklfows");
        }
    }
}