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
        public static ApiRoutineObsolete project(MemoryAddress @base, ApiCodeBlock code, Instruction[] src)
            => new ApiRoutineObsolete(@base, project(code, src));

        public static ApiInstruction[] project(ApiCodeBlock code, Instruction[] src)
        {
            var @base = code.Base;
            var offseq = OffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var len = fx.ByteLength;
                var data = span(code.Code.Data);
                var slice = data.Slice((int)offseq.Offset, len).ToArray();
                var recoded = new ApiCodeBlock(code.Uri, fx.IP, slice);
                dst[i] = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return dst;
        }

        public static ApiHostRoutines decode(IAsmDecoder decoder, in ApiHostCodeBlocks src)
        {
            var instructions = list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Empty;
            var target = list<Instruction>();
            var count = src.Length;

            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref src[i];
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = target[0].IP;

                instructions.Add(project(ip, block, target.ToArray()));
            }

            return new ApiHostRoutines(src.Host, instructions.ToArray());
        }

        public static void Run(IWfShell wf, in WfCaptureState state)
        {
            var index = ApiIndexService.blocks(wf);
            run(wf, state, index);
            process(wf, decode(wf, state.RoutineDecoder, index));
            ResBytesEmitter.create().WithIndex(index).Run(wf);
        }

        public static void run(IWfShell wf, IWfCaptureState state, in ApiCodeBlockIndex encoded)
        {
            try
            {
                var processor = new AsmProcessDriver(state, encoded);
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

        public static Span<ApiPartRoutines> decode(IWfShell wf, IAsmDecoder decoder, in ApiCodeBlockIndex src)
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
                        if(members.IsNonEmpty)
                        {
                            var fx = decode(decoder, members);
                            hostFx.Add(fx);
                            kHosts++;
                            kMembers += fx.RoutineCount;
                            kFx += fx.InstructionCount;
                        }
                        else
                            wf.Warn($"The host {host} has no members");
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