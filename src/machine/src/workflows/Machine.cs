//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    class Machine : IDisposable
    {
        readonly WfCaptureState State;

        readonly IWfShell Wf;

        readonly WfHost Host;

        internal Machine(WfCaptureState state, WfHost host)
        {
            Host = host;
            State = state;
            Wf = State.Wf.WithHost(host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.delimit(Wf.Api.PartIdentities));
            try
            {
                CaptureWorkflow.create(State).Run();
                //EmitReferenceData.create().Run(Wf);
                EmitFieldMetadata.create().Run(Wf);
                EmitSectionHeaders.create().Run(Wf);
                EmitImageConstants.create().Run(Wf);
                EmitLocatedParts.create().Run(Wf);
                EmitStringRecords.create().Run(Wf);
                EmitComments.create().Run(Wf);
                EmitImageBlobs.create().Run(Wf);
                EmitCilTables.create().Run(Wf);
                EmitEnumCatalog.create().Run(Wf);
                EmitFieldLiterals.create().Run(Wf);
                EmitBitMasks.create().Run(Wf);
                CaptureProcessors.Run(Wf,State);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}