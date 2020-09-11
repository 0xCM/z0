//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static Konst;
    using static EmitDatasetsStep;

    public ref partial struct EmitDatasets
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly ApiSet Parts;

        readonly bool Recapture;

        readonly EmitDatasetsStep Host;

        public EmitDatasets(IWfShell wf, EmitDatasetsStep host)
        {
            Wf = wf;
            Host = host;
            Ct = Wf.Ct;
            Recapture = false;
            Parts = Wf.Api.Parts;
            Wf.Created(host.Id);
        }


        void Run(EmitProjectDocsStep kind)
        {
            try
            {
                using var step = new EmitProjectDocs(Wf, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id, e);
            }
        }


        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        void Run(EmitResBytesStep kind)
        {
            try
            {
                using var step = new EmitResBytes(Wf, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id,e);
            }
        }

        void Run(EmitImageConstantsStep kind)
        {
            try
            {
                using var step = new EmitImageConstants(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitPeHeadersStep kind)
        {
            try
            {
                using var step = new EmitPeHeaders(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id,e);
            }
        }

        void Run(EmitImageContentStep kind)
        {
            try
            {
                using var step = new EmitImageContent(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id,e);
            }
        }

        void Run(EmitStringRecordsStep kind)
        {
            try
            {
                using var step = new EmitStringRecords(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitImageBlobsStep kind)
        {
            try
            {
                using var step = new EmitImageBlobs(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id,e);
            }
        }

        void Run(EmitFieldMetadataHost host)
            => host.Run(Wf);

        void Run(EmitPartCil kind)
        {
            try
            {
                using var step = new EmitPartCil(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id,e);
            }
        }

        void Run(EmitEnumCatalogStep kind)
        {
            using var step = new EmitEnumCatalog(Wf, Ct);
            step.Run();
        }

        void Run(EmitFieldLiteralsStep kind)
        {
            using var step = new EmitFieldLiterals(Wf, Ct);
            step.Run();
        }

        void Run(EmitContentCatalogStep kind)
        {
            using var step = new EmitContentCatalog(Wf, Ct);
            step.Run();
        }

        void Run(EmitBitMasksStep kind)
        {
            using var step = new EmitBitMasks(Wf, Ct);
            step.Run();
        }

        public void Run()
        {
            Run(new EmitImageConstantsStep());
            Run(new EmitPeHeadersStep());
            Run(new EmitImageContentStep());
            Run(new EmitStringRecordsStep());
            Run(new EmitImageBlobsStep());
            Run(new EmitFieldMetadataHost());
            Run(new EmitPartCil());
            Run(new EmitBitMasksStep());
            Run(new EmitProjectDocsStep());
            Run(new EmitResBytesStep());
            Run(new EmitEnumCatalogStep());
            Run(new EmitFieldLiteralsStep());
            Run(new EmitContentCatalogStep());
        }

        // void Run(RecaptureStep kind)
        // {
        //     var resources = ApiQuery.declarationIndex(Assembly.LoadFrom(Wf.ResPack.Name));
        //     using var step = new Recapture(asm(Wf.ContextRoot));
        //     step.CaptureResBytes();
        // }
    }
}