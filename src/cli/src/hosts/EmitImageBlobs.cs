//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [WfHost]
    public sealed class EmitImageBlobs : WfHost<EmitImageBlobs>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageBlobsStep(wf,this);
            step.Run();
        }
    }

    ref struct EmitImageBlobsStep
    {
        const string TableId = CliBlobInfo.TableId;

        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly IPart[] Parts;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitImageBlobsStep(IWfShell wf, WfHost host)
        {
            Wf = wf.WithHost(host);
            Host = host;
            Parts = Wf.Api.Parts;
            EmissionCount = 0;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }


        public void Run()
        {
            var flow = Wf.Running();
            var service = ImageDataEmitter.init(Wf);
            service.ClearBlobs();
            foreach(var part in Parts)
                service.EmitBlobs(part.Owner);
            Wf.Ran(flow);
        }
    }
}