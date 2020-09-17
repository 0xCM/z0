//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static EmitMetadataSetsHost;

    public readonly ref struct EmitMetadataSets
    {
        public readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        readonly EmitMetadataSetsHost Host;

        public EmitMetadataSets(IWfShell wf)
        {
            Wf = wf;
            Ct = wf.Ct;
            Parts = Wf.Api.Parts;
            Host = new EmitMetadataSetsHost();
            Wf.Created(Host.Id, Ct);
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        // public void Run()
        // {
        //     Wf.Running(Host.Id);
        //     Run(new EmitImageConstantsStep());
        //     Run(new EmitPeHeadersStep());
        //     Run(new EmitPartCil());
        //     Run(new EmitImageDataStep());
        //     Run(new EmitStringRecordsStep());
        //     Run(new EmitImageBlobsStep());
        //     Run(new EmitFieldMetadataHost());
        //     Wf.Ran(Host.Id);
        // }

        // void Run(EmitImageConstantsStep kind)
        // {
        //     try
        //     {
        //         using var step = new EmitImageConstants(Wf, Parts, Ct);
        //         step.Run();
        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(kind.GetType(), e);
        //     }
        // }

        // void Run(EmitPeHeadersStep kind)
        // {
        //     try
        //     {
        //         using var step = new EmitPeHeaders(Wf, Parts, Ct);
        //         step.Run();
        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(kind.GetType(), e);
        //     }
        // }

        // void Run(EmitPartCil kind)
        // {
        //     try
        //     {
        //         // using var step = new EmitPartCil(Wf, Parts, Ct);
        //         // step.Run();
        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(typeof(EmitPartCil), e);
        //     }
        // }

        // void Run(EmitImageDataStep kind)
        // {
        //     try
        //     {
        //         using var step = new EmitImageData(Wf, Parts, Ct);
        //         step.Run();
        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(kind.GetType(), e);
        //     }
        // }

        // void Run(EmitStringRecordsStep host)
        // {
        //     try
        //     {
        //         using var step = new EmitStringRecords(Wf,host);
        //         step.Run();
        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(host.GetType(), e);
        //     }
        // }

        // void Run(EmitImageBlobsStep kind)
        // {

        //     try
        //     {
        //         using var step = new EmitImageBlobs(Wf, Parts, Ct);
        //         step.Run();
        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(e, Ct);
        //     }
        // }

        // void Run(EmitFieldMetadataHost host)
        //     => host.Run(Wf);

    }
}