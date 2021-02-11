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
        public ApiAsmDataset Decode()
            => Decode(ApiIndex.service(Wf).CreateApiBlocks());

        public ApiAsmDataset Decode(ApiCodeBlocks src)
        {
            var decoder = Asm.RoutineDecoder;
            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = root.list<ApiHostRoutines>();
            var stats = ApiDecoderStats.init();

            Wf.Status($"Decoding {partCount} parts");

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

                    Wf.Status($"Decoding {hostCount} {part} hosts");

                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        Wf.Status($"Decoding {host}");

                        var members = src.HostCodeBlocks(host);
                        if(members.IsNonEmpty)
                        {
                            Wf.Status($"Decoding {members.Count} {host} members");

                            var fx = Decode(members);
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

            Wf.Status(text.format(WfProgress.DecodedMachine, src.EntryCount, src.Parts.Length));
            return new ApiAsmDataset(src, dst);
        }

        public ApiHostRoutines Decode(ApiHostCode src)
        {
            var instructions = root.list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Zero;
            var target = root.list<IceInstruction>();
            var count = src.Length;
            var decoder = Asm.RoutineDecoder;
            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref src[i];
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = target[0].IP;

                instructions.Add(Load(ip, block, target.ToArray()));
            }

            return new ApiHostRoutines(src.Host, instructions.ToArray());
        }

        ApiRoutineObsolete Load(MemoryAddress @base, ApiCodeBlock code, IceInstruction[] src)
            => new ApiRoutineObsolete(@base, AsmEtl.ApiInstructions(code, src));
    }

    readonly struct WfProgress
    {
        public const string DecodedPart = "Decoded {0} routines from {1}";

        public const string DecodedMachine = "Decoded {0} routines from {1} parts";
    }
}