//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static z;

    public delegate ApiHostRoutines HostBlockDecoder(in ApiHostCodeBlocks blocks);

    public ref struct ApiProcessors
    {
        public static ApiProcessors create(IWfShell wf, IAsmContext asm)
        {
            var processors = new ApiProcessors(wf, asm);
            processors.Index = ApiIndexService.init(wf).CreateIndex();
            processors.Decoded = processors.DecodeIndex();
            return processors;
        }

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        ApiCodeBlockIndex Index;

        Span<ApiPartRoutines> Decoded;

        ApiProcessors(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            Index = default;
            Decoded = default;
        }

        public void Run()
        {
            try
            {
                EmitAsmRows();
                ProcessCalls();
                ProcessJumps();
                ProcessEnlisted();
                ProcessSemantic();
                ResBytesEmitter.create().WithIndex(Index).Run(Wf);

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void ProcessCalls()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
            {
                var processor = PartRoutinesProcessor.service(Wf, skip(Decoded,i));
                processor.ProcessCalls();
            }
        }

        void ProcessJumps(ApiPartRoutines src)
        {
            using var step = new AsmJmpProcessor(Wf, src);
            step.Process();
        }

        void ProcessJumps()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
            {
                // var processor = PartRoutinesProcessor.service(Wf, skip(Decoded,i));
                // processor.ProcessJumps();
                ProcessJumps(skip(Decoded,i));
            }
        }

        void ProcessEnlisted()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                AsmProcessors.parts(Wf).Process(skip(Decoded,i));
        }


        void ProcessSemantic()
        {
            using var service = AsmSemanticRender.create(Wf);
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                service.Render(skip(Decoded, i));
        }

        void EmitAsmRows()
        {
            try
            {
                var processor = new AsmProcessDriver(Wf, Asm, Index);
                var result = processor.Process();
                var records = 0u;

                Wf.Processed(Seq.delimit(nameof(AsmRow), Index.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                Wf.Status($"Emitting {count} instruction tables");
                for(var i=0; i<count; i++)
                    records += AsmTables.emit(Wf, skip(sets,i));
                Wf.Status($"Emitted a total of {records} records for {count} instruction tables");

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        Span<ApiPartRoutines> DecodeIndex()
        {
            var decoder = Asm.RoutineDecoder;
            var parts = Index.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = list<ApiHostRoutines>();
            var stats = ApiDecoderStats.init();
            var svc = ApiInstructionService.create(Wf);

            Wf.Status($"Decoding {partCount} parts");

            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                else
                {
                    var hosts = Index.Hosts.Where(h => h.Owner == part);
                    var hostCount = hosts.Length;

                    Wf.Status($"Decoding {hostCount} {part} hosts");

                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        Wf.Status($"Decoding {host}");

                        var members = Index.HostCodeBlocks(host);
                        if(members.IsNonEmpty)
                        {
                            Wf.Status($"Decoding {members.Count} {host} members");

                            var fx = svc.Decode(decoder, members);
                            hostFx.Add(fx);
                            stats.HostCount++;
                            stats.MemberCount += fx.RoutineCount;
                            stats.InstructionCount += fx.InstructionCount;
                        }
                        else
                            Wf.Warn($"The host {host} has no members");
                    }

                    Wf.Status(text.format(WfProgress.DecodedPart, hostFx.Count, part.Format()));
                    dst[i] = new ApiPartRoutines(part, hostFx.ToArray());

                    stats.PartCount++;
                    Wf.Status(stats.Format());
                }
            }

            Wf.Status(text.format(WfProgress.DecodedMachine, Index.EntryCount, Index.Parts.Length));
            return dst;
        }
    }
}