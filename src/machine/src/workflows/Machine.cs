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
            Host = host;
            State = state;
            Wf = State.Wf.WithHost(host);
            Index = default;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();
            Wf.Status(delimit(Wf.Api.PartIdentities));

            try
            {
                EmitFieldMetadata.create().Run(Wf);
                EmitSectionHeaders.create().Run(Wf);
                EmitImageConstants.create().Run(Wf);
                EmitLocatedPartsHost.create().Run(Wf);
                EmitStringRecords.create().Run(Wf);
                EmitProjectDocsHost.create().Run(Wf);
                EmitImageBlobs.create().Run(Wf);
                EmitCilTables.create().Run(Wf);
                EmitEnumCatalog.create().Run(Wf);
                EmitFieldLiterals.create().Run(Wf);
                EmitReferenceData.create().Run(Wf);
                EmitBitMasks.create().Run(Wf);
                BuildCaptureIndex.run(Wf, State, out Index);
                EmitResBytes.create().WithIndex(Index).Run(Wf);
            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran();
        }
    }
}