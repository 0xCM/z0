//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;

    public sealed class ApiDecoder : WfService<ApiDecoder,IApiDecoder,IAsmContext>, IApiDecoder
    {
        public Span<ApiPartRoutines> DecodeIndex(ApiCodeBlocks index)
        {
            var decoder = Context.RoutineDecoder;
            var parts = index.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = list<ApiHostRoutines>();
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
                    var hosts = index.Hosts.Where(h => h.Owner == part);
                    var hostCount = hosts.Length;

                    Wf.Status($"Decoding {hostCount} {part} hosts");

                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        Wf.Status($"Decoding {host}");

                        var members = index.HostCodeBlocks(host);
                        if(members.IsNonEmpty)
                        {
                            Wf.Status($"Decoding {members.Count} {host} members");

                            var fx = DecodeBlocks(members);
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

            Wf.Status(text.format(WfProgress.DecodedMachine, index.EntryCount, index.Parts.Length));
            return dst;
        }

        public ApiHostRoutines DecodeBlocks(ApiHostCode src)
        {
            var instructions = list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Zero;
            var target = list<IceInstruction>();
            var count = src.Length;
            var decoder = Context.RoutineDecoder;
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
            => new ApiRoutineObsolete(@base, Load(code, src));

        ApiInstruction[] Load(ApiCodeBlock code, IceInstruction[] src)
        {
            var @base = code.BaseAddress;
            var offseq = AsmOffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var len = fx.ByteLength;
                var data = span(code.Storage);
                var slice = data.Slice((int)offseq.Offset, len).ToArray();
                var recoded = new ApiCodeBlock(fx.IP, code.Uri, slice);
                dst[i] = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return dst;
        }
    }

    readonly struct WfProgress
    {
        public const string DecodedPart = "Decoded {0} routines from {1}";

        public const string DecodedMachine = "Decoded {0} routines from {1} parts";
    }
}