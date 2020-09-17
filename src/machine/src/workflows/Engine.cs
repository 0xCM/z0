//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static Engines;
    using static z;

    public class Engine : IDisposable
    {
        readonly WfCaptureState State;

        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        internal Engine(WfCaptureState state, CorrelationToken ct)
        {
            State = state;
            Wf = State.Wf;
            Ct = ct;
            Wf.Created(StepId, delimit(Wf.Api.PartIdentities));
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        IAsmContext Asm
            => State.Asm;

        public void Run()
        {
            Wf.Running(StepId);

            try
            {
                Run(new EmitFieldMetadataHost());
                Run(new ProcessPartFilesHost());
                Run(new EmitPeHeadersStep());
                Run(new EmitImageConstantsStep());
                Run(new EmitImageDataStep());
                Run(new EmitStringRecordsStep());
                Run(new EmitProjectDocsHost());
                Run(new EmitResBytesStep());
                Run(new EmitImageBlobsStep());
                Run(new EmitPartCilStep());
                Run(new EmitEnumCatalogHost());
                Run(new EmitFieldLiteralsHost());
                Run(new EmitContentCatalogStep());
                Run(new EmitBitMasksStep());
                Run(new CreateGlobalIndexHost());

            }
            catch(Exception e)
            {
                term.error(e);
            }

            Wf.Ran(StepId);
        }

        void Run(CreateGlobalIndexHost host)
        {
            Wf.Running(host.Id);
            using var step = new CreateGlobalIndex(Wf, host, State, Archives.partfiles(Wf.CaptureRoot));
            step.Run();
            Wf.Ran(host.Id);
        }

        void Run(ManageCaptureHost step, params string[] args)
        {
            using var control = WfCaptureControl.create(State);
            control.Run();
        }

        void Run(EmitImageConstantsStep host)
        {
            using var step = new EmitImageConstants(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitFieldMetadataHost host)
            => host.Run(Wf);

        void Run(EmitEnumCatalogHost host)
            => host.Run(Wf);

        // {
        //     using var step = new EmitEnumCatalog(Wf, host);
        //     step.Run();
        // }

        void Run(EmitFieldLiteralsHost host)
            => host.Run(Wf);

        void Run(EmitContentCatalogStep kind)
        {
            using var step = new EmitContentCatalog(Wf);
            step.Run();
        }

        void Run(EmitBitMasksStep kind)
        {
            using var step = new EmitBitMasks(Wf, Ct);
            step.Run();
        }

        void Run(EmitPartCilStep host)
        {
            using var step = new EmitPartCil(Wf, host);
            step.Run();
        }

        void Run(EmitImageBlobsStep host)
        {
            using var step = new EmitImageBlobs(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitPeHeadersStep host)
        {
            using var step = new EmitPeHeaders(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitImageDataStep host)
        {
            using var step = new EmitImageData(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitStringRecordsStep host)
        {
            using var step = new EmitStringRecords(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitProjectDocsHost host)
        {
            using var step = new EmitProjectDocs(Wf, Ct);
            step.Run();
        }

        void Run(EmitResBytesStep host)
        {
            using var step = new EmitResBytes(Wf, Ct);
            step.Run();
        }

        void Run(ProcessPartFilesHost host)
        {
            using var step = new ProcessPartFiles(Wf, Asm, Ct);
            step.Run();
        }
    }
}