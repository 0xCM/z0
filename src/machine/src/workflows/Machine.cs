//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static z;

    public class Machine : IDisposable
    {
        readonly WfCaptureState State;

        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        readonly WfHost Host;

        internal Machine(WfCaptureState state, WfHost host)
        {
            State = state;
            Wf = State.Wf;
            Host = host;
            Ct = Wf.Ct;
            Wf.Created(Host, delimit(Wf.Api.PartIdentities));
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        IAsmContext Asm
            => State.Asm;

        public void Run()
        {
            Wf.Running(Host);

            try
            {
                Run(new EmitFieldMetadataHost());
                Run(new ProcessPartFilesHost());
                Run(new EmitPeHeadersStep());
                Run(new EmitImageConstantsStep());
                Run(new EmitImageDataStep());
                Run(new EmitStringRecordsHost());
                Run(new EmitProjectDocsHost());
                Run(new EmitResBytesStep());
                Run(new EmitImageBlobsHost());
                Run(new EmitPartCilHost());
                Run(new EmitEnumCatalogHost());
                Run(new EmitFieldLiteralsHost());
                Run(new EmitContentCatalogHost());
                Run(new EmitBitMasksHost());
                Run(new CreateGlobalIndexHost());

            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host);
        }

        void Run(CreateGlobalIndexHost host)
        {
            Wf.Running(host.Id);
            using var step = new CreateGlobalIndex(Wf, host, State, Archives.partfiles(Wf.CaptureRoot));
            step.Run();
            Wf.Ran(host.Id);
        }

        void Run(EmitImageConstantsStep host)
        {
            using var step = new EmitImageConstants(Wf, host);
            step.Run();
        }

        void Run(EmitFieldMetadataHost host)
            => host.Run(Wf);

        void Run(EmitEnumCatalogHost host)
            => host.Run(Wf);

        void Run(EmitFieldLiteralsHost host)
            => host.Run(Wf);

        void Run(EmitPartCilHost host)
            => host.Run(Wf);

        void Run(ProcessPartFilesHost host)
            => host.Run(Wf.With(Asm));

        void Run(EmitContentCatalogHost host)
            => host.Run(Wf);

        void Run(EmitBitMasksHost host)
            => host.Run(Wf);

        void Run(EmitProjectDocsHost host)
            => host.Run(Wf);

        void Run(EmitStringRecordsHost host)
            => host.Run(Wf);

        void Run(EmitImageBlobsHost host)
        {
            using var step = new EmitImageBlobs(Wf, host);
            step.Run();
        }

        void Run(EmitPeHeadersStep host)
        {
            using var step = new EmitImageHeaders(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitImageDataStep host)
        {
            using var step = new EmitImageData(Wf, Wf.Api.Parts, Ct);
            step.Run();
        }

        void Run(EmitResBytesStep host)
        {
            using var step = new EmitResBytes(Wf, Ct);
            step.Run();
        }
    }
}