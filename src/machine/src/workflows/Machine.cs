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


        ApiCodeBlockIndex Index;

        internal Machine(WfCaptureState state, WfHost host)
        {
            State = state;
            Wf = State.Wf;
            Host = host;
            Index = default;
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
                //ProcessPartFiles.create().Run(Wf, AsmContextProvider.create(State.Asm));
                EmitFieldMetadata.create().Run(Wf);
                EmitSectionHeadersHost.create().Run(Wf);
                EmitImageConstants.create().Run(Wf);
                EmitLocatedPartsHost.create().Run(Wf);
                EmitStringRecords.create().Run(Wf);
                EmitProjectDocsHost.create().Run(Wf);
                EmitImageBlobs.create().Run(Wf);
                EmitCilTables.create().Run(Wf);
                EmitEnumCatalog.create().Run(Wf);
                EmitFieldLiterals.create().Run(Wf);
                EmitContentCatalog.create().Run(Wf);
                EmitBitMasksHost.create().Run(Wf);
                BuildCaptureIndex.run(Wf, State, out Index);
                EmitResBytes.create().WithIndex(Index).Run(Wf);
            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host);
        }
    }
}