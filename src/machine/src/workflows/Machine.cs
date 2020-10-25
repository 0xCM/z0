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

        public static ApiCodeBlockIndex BuildIndex(IWfShell wf, WfHost host)
        {
            wf = wf.WithHost(host);
            using var builder = new ApiIndexBuilder(wf, host);
            builder.Run();
            var target = builder.Product;
            wf.Raise(new PartIndexCreated(host, target, wf.Ct));
            return target;
        }

        public static void EmitAsmTables(IWfShell wf, IWfCaptureState state, in ApiCodeBlockIndex encoded)
        {
            try
            {
                var processor = new ProcessAsm(state, encoded);
                var result = processor.Process();

                wf.Processed(delimit(nameof(AsmRow), encoded.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                    BuildCaptureIndex.process(wf, skip(sets,i));
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        public static Span<ApiPartRoutines> DecodeParts(IWfShell wf, IAsmDecoder decoder, in ApiCodeBlockIndex src)
        {
            return BuildCaptureIndex.DecodeParts(wf, decoder, src);
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
                EmitComments.create().Run(Wf);
                EmitImageBlobs.create().Run(Wf);
                EmitCilTables.create().Run(Wf);
                EmitEnumCatalog.create().Run(Wf);
                EmitFieldLiterals.create().Run(Wf);
                EmitReferenceData.create().Run(Wf);
                EmitBitMasks.create().Run(Wf);
                Index = BuildIndex(Wf, Host);
                EmitAsmTables(Wf, State, Index);
                var routines = DecodeParts(Wf, State.RoutineDecoder, Index);
                BuildCaptureIndex.process(Wf,routines);
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