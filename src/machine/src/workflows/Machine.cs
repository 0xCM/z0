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

    class Machine : IDisposable
    {
        readonly WfCaptureState State;

        readonly IWfShell Wf;

        readonly WfHost Host;

        internal Machine(WfCaptureState state, WfHost host)
        {
            State = state;
            Wf = State.Wf;
            Host = host;
            Wf.Created(Host, delimit(Wf.Api.PartIdentities));
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host);

            try
            {
                Run(new EmitFieldMetadataHost());
                Run(new ProcessPartFiles());
                Run(new EmitSectionHeadersHost());
                Run(new EmitImageConstantsHost());
                Run(new EmitLocatedPartsHost());
                Run(new EmitStringRecords());
                Run(new EmitProjectDocsHost());
                Run(new EmitResBytesHost());
                Run(new EmitImageBlobsHost());
                Run(new EmitPartCilHost());
                Run(new EmitEnumCatalogHost());
                Run(new EmitFieldLiteralsHost());
                Run(new EmitContentCatalogHost());
                Run(new EmitBitMasksHost());
                CreateCaptureIndexHost.run(Wf, State);

            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host);
        }

        void Run(EmitImageConstantsHost host)
            => host.Run(Wf);

        void Run(EmitFieldMetadataHost host)
            => host.Run(Wf);

        void Run(EmitEnumCatalogHost host)
            => host.Run(Wf);

        void Run(EmitFieldLiteralsHost host)
            => host.Run(Wf);

        void Run(EmitPartCilHost host)
            => host.Run(Wf);

        void Run(ProcessPartFiles host)
            => host.Run(Wf, AsmContextProvider.create(State.Asm));

        void Run(EmitContentCatalogHost host)
            => host.Run(Wf);

        void Run(EmitBitMasksHost host)
            => host.Run(Wf);

        void Run(EmitProjectDocsHost host)
            => host.Run(Wf);

        void Run(EmitStringRecords host)
            => host.Run(Wf);

        void Run(EmitImageBlobsHost host)
            => host.Run(Wf);

        void Run(EmitSectionHeadersHost host)
            => host.Run(Wf);

        void Run(EmitLocatedPartsHost host)
            => host.Run(Wf);

        void Run(EmitResBytesHost host)
            => host.Run(Wf);
    }
}