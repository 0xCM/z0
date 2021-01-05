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
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        internal Machine(IWfShell wf, IAsmContext asm)
        {
            Host = WfShell.host(typeof(Machine));
            Wf = wf.WithHost(Host);
            Asm = asm;
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
                //ApiCaptureRunner.run(Wf);
                ResDataEmitter.index(Wf);
                ResDataEmitter.reference(Wf);
                XedEtlWfHost.create().Run(Wf);

                var emitters = ImageEmitters.init(Wf);
                emitters.EmitSectionHeaders();
                emitters.EmitCilRecords();
                emitters.EmitUserStrings();
                emitters.EmitSystemStrings();

                //EmitStringRecords.create().Run(Wf);

                EmitFieldMetadata.create().Run(Wf);
                EmitImageConstants.create().Run(Wf);
                EmitLocatedParts.create().Run(Wf);
                EmitComments.create().Run(Wf);
                EmitImageBlobs.create().Run(Wf);


                EmitEnumCatalog.create().Run(Wf);
                EmitFieldLiterals.create().Run(Wf);
                EmitBitMasks.create().Run(Wf);

                var processors = ApiProcessors.create(Wf, Asm);
                processors.EmitAsmRows();
                processors.ProcessCalls();
                processors.ProcessJumps();
                processors.ProcessEnlisted();
                processors.ProcessSemantic();
                processors.EmitResBytes();

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}