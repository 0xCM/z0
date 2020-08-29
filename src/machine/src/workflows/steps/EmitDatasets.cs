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
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly IPart[] Parts;

        readonly bool Recapture;

        public EmitDatasets(IWfContext context, CorrelationToken ct)
        {
            Ct = ct;
            Wf = context;
            Recapture = false;
            Parts = ModuleArchives.executing().Parts;
            Wf.Created(StepId);
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
                Wf.Error(e, Ct);
            }
        }


        public void Dispose()
        {
            Wf.Finished(StepId);
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
                Wf.Error(e, Ct);
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
                Wf.Error(e, Ct);
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
                Wf.Error(e, Ct);
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
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitFieldMetadataStep kind)
        {
            try
            {
                using var step = new EmitFieldMetadata(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }
        }

        void Run(EmitPartCil kind)
        {
            try
            {
                using var step = new EmitPartCil(Wf, Parts, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
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
            Run(default(EmitImageConstantsStep));
            Run(default(EmitPeHeadersStep));
            Run(default(EmitImageContentStep));
            Run(default(EmitStringRecordsStep));
            Run(default(EmitImageBlobsStep));
            Run(default(EmitFieldMetadataStep));
            Run(default(EmitPartCil));
            Run(default(EmitBitMasksStep));
            Run(default(EmitProjectDocsStep));
            Run(default(EmitResBytesStep));
            Run(default(EmitEnumCatalogStep));
            Run(default(EmitFieldLiteralsStep));
            Run(default(EmitContentCatalogStep));
        }

        [MethodImpl(Inline), Op]
        static IAsmContext asm(IAppContext root)
            => new AsmContext(root);

        void Run(RecaptureStep kind)
        {
            var resources = Resources.code(Assembly.LoadFrom(Wf.ResPack.Name));
            using var step = new Recapture(asm(Wf.ContextRoot));
            step.CaptureResBytes();
        }
    }
}