//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static memory;

    public sealed class ApiIndexDecoder : AsmWfService<ApiIndexDecoder>, IApiIndexDecoder
    {
        public ApiAsmDataset Decode(ApiBlockIndex src)
        {
            var decoder = Asm.RoutineDecoder;
            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = root.list<ApiHostRoutines>();
            var stats = ApiDecoderStats.init();
            var flow = Wf.Running(Msg.DecodingParts.Format(parts.Count));

            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                else
                {
                    var hosts = src.Hosts.Where(h => h.Part == part).View;
                    var hostCount = hosts.Length;

                    var decoding = Wf.Running(Msg.DecodingPartRoutines.Format(hostCount, part));
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

                    var decoded = string.Format("{0} | {1}", Msg.DecodedPartRoutines.Format(hostFx.Count, part), stats.Format());
                    Wf.Ran(decoding, decoded);
                }
            }

            Wf.Ran(flow, Msg.DecodedMachine.Format(src.EntryCount, src.Parts.Length));
            return new ApiAsmDataset(src, dst);
        }

        public ApiHostRoutines Decode(ApiHostCode src)
        {
            var host = src.Host;
            var flow = Wf.Running(Msg.DecodingHostRoutines.Format(host));
            var routines = DecodeRoutines(src);
            Wf.Ran(flow, Msg.DecodedHostRoutines.Format(routines.Length, host));
            return routines;
        }

        ApiHostRoutines DecodeRoutines(ApiHostCode src)
        {
            var host = src.Host;
            var view = src.Blocks.View;
            var count = view.Length;
            var instructions = root.list<ApiInstructionBlock>();
            var ip = MemoryAddress.Zero;
            var target = root.list<IceInstruction>();
            var decoder = Asm.RoutineDecoder;
            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref skip(view,i);
                var decoded = decoder.Decode(block, x => target.Add(x));
                if(decoded)
                {
                    if(i == 0)
                        ip = target[0].IP;
                     instructions.Add(Etl.ApiInstructionBlock(ip, block, target.ToArray()));
                }
                else
                    Wf.Warn($"Decoder failure for {block.OpUri}");

            }

            return new ApiHostRoutines(host, instructions.ToArray());
        }
    }
}