//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    public sealed class ApiIndexDecoder : AsmWfService<ApiIndexDecoder>, IApiIndexDecoder
    {
        public ApiAsmDataset Decode(ApiCodeBlocks src)
        {
            var decoder = Asm.RoutineDecoder;
            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = root.list<ApiHostRoutines>();
            var stats = ApiDecoderStats.init();

            var flow = Wf.Running($"Decoding {partCount} parts");

            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                else
                {
                    var hosts = src.Hosts.Where(h => h.Owner == part).View;
                    var hostCount = hosts.Length;

                    var inner = Wf.Running($"Decoding {hostCount} {part} hosts");

                    for(var j=0; j<hostCount; j++)
                    {
                        ref readonly var host = ref skip(hosts,j);
                        var blocks = src.HostCodeBlocks(host);
                        if(blocks.IsNonEmpty)
                        {
                            var routines = Decode(blocks);
                            hostFx.Add(routines);
                            stats.HostCount++;
                            stats.MemberCount += routines.RoutineCount;
                            stats.InstructionCount += routines.InstructionCount;
                        }
                        else
                            Wf.Warn($"The host {host} has no members");
                    }
                    dst[i] = new ApiPartRoutines(part, hostFx.ToArray());
                    stats.PartCount++;

                    Wf.Ran(inner, string.Format("{0} | {1}",
                        text.format(WfProgress.DecodedPart, hostFx.Count, part.Format()),
                        stats.Format()));
                }
            }

            Wf.Ran(flow, text.format(WfProgress.DecodedMachine, src.EntryCount, src.Parts.Length));
            return new ApiAsmDataset(src, dst);
        }

        public ApiHostRoutines Decode(ApiHostCode src)
        {
            var host = src.Host;
            var flow = Wf.Running($"Decoding {host} routines");
            var routines = DecodeRoutines(src);
            Wf.Ran(flow, $"Decoded {routines.Length} {host} routines");
            return routines;
        }

        ApiHostRoutines DecodeRoutines(ApiHostCode src)
        {
            var host = src.Host;
            var view = src.Blocks.View;
            var count = view.Length;
            var instructions = root.list<ApiInstructionSet>();
            var ip = MemoryAddress.Zero;
            var target = root.list<IceInstruction>();
            var decoder = Asm.RoutineDecoder;
            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref skip(view,i);
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = target[0].IP;

                instructions.Add(Load(ip, block, target.ToArray()));
            }

            return new ApiHostRoutines(host, instructions.ToArray());
        }

        ApiInstructionSet Load(MemoryAddress @base, ApiCodeBlock code, IceInstruction[] src)
            => new ApiInstructionSet(@base, AsmEtl.ApiInstructions(code, src));
    }

    readonly struct WfProgress
    {
        public const string DecodedPart = "Decoded {0} routines from {1}";

        public const string DecodedMachine = "Decoded {0} routines from {1} parts";
    }
}