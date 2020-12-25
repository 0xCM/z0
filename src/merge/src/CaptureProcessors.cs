//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    public delegate ApiHostRoutines HostBlockDecoder(in ApiHostCodeBlocks blocks);

    public readonly struct CaptureProcessors
    {
        public static void Run(IWfShell wf, IAsmContext asm)
        {
            var svc = ApiIndexService.init(wf);
            var index = svc.CreateIndex();
            run(wf, asm, index);
            process(wf, decode(wf, asm, index));
            ResBytesEmitter.create().WithIndex(index).Run(wf);
        }

        public static void process(IWfShell wf, ReadOnlySpan<ApiPartRoutines> src)
        {
            try
            {
                EmitCallIndex.exec(wf,src);
                AsmJmpProcessor.exec(wf,src);
                AsmProcessors.exec(wf,src);
                AsmSemanticRender.exec(wf,src);
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        public static void run(IWfShell wf, IAsmContext asm, in ApiCodeBlockIndex encoded)
        {
            try
            {
                var processor = new AsmProcessDriver(wf, asm, encoded);
                var result = processor.Process();
                var records = 0u;

                wf.Processed(Seq.delimit(nameof(AsmRow), encoded.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                wf.Status($"Emitting {count} instruction tables");
                for(var i=0; i<count; i++)
                    records += emit(wf, skip(sets,i));
                wf.Status($"Emitted a total of {records} records for {count} instruction tables");

            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        public static uint emit(IWfShell wf, in AsmRowSet<Mnemonic> src)
        {
            var count = (uint)src.Count;
            if(count != 0)
            {
                var dst = wf.Db().Table(AsmRow.TableId, src.Key.ToString());
                var records = span(src.Sequenced);
                var formatter = Formatters.dataset<AsmRowField>();
                var header = Table.header53<AsmRowField>();

                wf.EmittingTable<AsmRow>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(header);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var line = AsmRow.format(record, formatter).Render();
                    writer.WriteLine(line);
                }
                wf.EmittedTable<AsmRow>(count, dst);
            }
            return count;
        }

        public static Span<ApiPartRoutines> decode(IWfShell wf, IAsmContext asm, in ApiCodeBlockIndex src)
        {
            var decoder = asm.RoutineDecoder;
            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = list<ApiHostRoutines>();
            var stats = ApiDecoderStats.init();
            var svc = ApiInstructionService.create(wf);

            wf.Status($"Decoding {partCount} parts");

            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                else
                {
                    var hosts = src.Hosts.Where(h => h.Owner == part);
                    var hostCount = hosts.Length;

                    wf.Status($"Decoding {hostCount} {part} hosts");

                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        wf.Status($"Decoding {host}");

                        var members = src.HostCodeBlocks(host);
                        if(members.IsNonEmpty)
                        {
                            wf.Status($"Decoding {members.Count} {host} members");

                            var fx = svc.Decode(decoder, members);
                            hostFx.Add(fx);
                            stats.HostCount++;
                            stats.MemberCount += fx.RoutineCount;
                            stats.InstructionCount += fx.InstructionCount;
                        }
                        else
                            wf.Warn($"The host {host} has no members");
                    }

                    wf.Status(text.format(WfProgress.DecodedPart, hostFx.Count, part.Format()));
                    dst[i] = new ApiPartRoutines(part, hostFx.ToArray());

                    stats.PartCount++;
                    wf.Status(stats.Format());
                }
            }

            wf.Status(text.format(WfProgress.DecodedMachine, src.EntryCount, src.Parts.Length));
            return dst;
        }
    }
}