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

    public delegate ApiHostRoutines HostBlockDecoder(in ApiHostCodeBlocks blocks);

    public readonly struct CaptureProcessors
    {
        public static ApiHostRoutines DecodeBlocks(IAsmDecoder decoder, in ApiHostCodeBlocks blocks)
        {
            var instructions = list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Empty;
            var target = list<Instruction>();
            var count = blocks.Length;

            for(var i=0; i<count; i++)
            {
                target.Clear();

                ref readonly var block = ref blocks[i];
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = target[0].IP;

                instructions.Add(AsmProjections.project(ip, block, target.ToArray()));
            }

            return new ApiHostRoutines(blocks.Host, instructions.ToArray());
        }

        public static ApiCodeBlockIndex BuildIndex(IWfShell wf, WfHost host)
        {
            using var builder = new MemoryIndexBuilder(wf, host);
            builder.Run();
            var target = builder.Product;
            var metrics = MemoryIndexMetrics.from(target);
            wf.Status(MemoryIndexMetrics.from(target));
            return target;
        }

        public static void Run(IWfShell wf, in WfCaptureState state)
        {
            var index = BuildIndex(wf, WfShell.host(typeof(CaptureProcessors)));
            run(wf, state, index);
            process(wf, DecodeIndex(wf, state.RoutineDecoder, index));
            ResBytesEmitter.create().WithIndex(index).Run(wf);
        }

        public static void DecodePart(PartId part, HostBlockDecoder decoder, in ApiCodeBlockIndex src, ref ApiPartRoutines dst)
        {
            var hosts = @readonly(src.Hosts.Where(h => h.Owner == part));
            var count = hosts.Length;
            var buffer = alloc<ApiHostRoutines>(count);
            ref var _dst = ref first(span(buffer));
            for(var j=0; j<count; j++)
            {
                ref readonly var host = ref skip(hosts,j);
                var blocks = src[host];
                var decoded = decoder(blocks);
                seek(_dst,j) = decoded;
            }
            dst = new ApiPartRoutines(part, buffer);
        }

        public static void run(IWfShell wf, IWfCaptureState state, in ApiCodeBlockIndex encoded)
        {
            try
            {
                var processor = new AsmProcessDriver(state, encoded);
                var result = processor.Process();

                wf.Processed(delimit(nameof(AsmRow), encoded.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                    ProcessEnlisted(wf, skip(sets,i));
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }

        public static void ProcessEnlisted(IWfShell wf, in AsmRowSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = span(src.Sequenced);
            var dst = wf.Db().Table(AsmRow.TableId, src.Key.ToString());

            var formatter = Formatters.dataset<AsmRowField>();
            var header = Table.header53<AsmRowField>();
            using var writer = dst.Writer();
            writer.WriteLine(header);
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRow.format(skip(records,i), formatter).Render());

            wf.EmittedTable<AsmRow>(count, dst);
        }

        public static Span<ApiPartRoutines> DecodeIndex(IWfShell wf, IAsmDecoder decoder, in ApiCodeBlockIndex src)
        {
            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = list<ApiHostRoutines>();
            var kMembers = 0u;
            var kHosts = 0u;
            var kParts = 0u;
            var kFx = 0u;

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


                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        var members = src[host];
                        var fx = DecodeBlocks(decoder, members);
                        hostFx.Add(fx);
                        kHosts++;
                        kMembers += fx.RoutineCount;
                        kFx += fx.InstructionCount;
                    }

                    wf.Status(text.format(WfProgress.DecodedPart, hostFx.Count, part.Format()));
                    dst[i] = new ApiPartRoutines(part, hostFx.ToArray());

                    kParts++;
                    wf.Status(text.format(WfProgress.DecodingMachine, kParts, kHosts, kMembers, kFx));
                }
            }

            wf.Status(text.format(WfProgress.DecodedMachine, src.EntryCount, src.Parts.Length));
            return dst;
        }

        public static void process(IWfShell wf, ReadOnlySpan<ApiPartRoutines> src)
        {
            var processors = ProcessInstructions.create();
            try
            {
                var count = src.Length;
                for(var i=0; i<count; i++)
                    processors.Run(wf, skip(src,i));
            }
            catch(Exception e)
            {
                wf.Error(e);
            }
        }
    }
}