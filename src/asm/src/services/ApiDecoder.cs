//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public sealed class ApiDecoder : AppService<ApiDecoder>
    {
        IAsmRoutineFormatter Formatter;

        AsmRoutineDecoder Decoder;

        AsmEtl Etl;

        protected override void OnInit()
        {
            Formatter = new AsmRoutineFormatter();
            Decoder = Wf.AsmDecoder();
            Etl = Wf.AsmEtl();
        }

        public ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath target)
        {
            var count = src.Length;
            var dst = span<AsmRoutineCode>(count);
            using var writer = target.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(Decoder.Decode(captured, out var routine))
                {
                    var asm = Formatter.Format(routine);
                    seek(dst,i) = new AsmRoutineCode(routine,captured, asm);
                    writer.Write(asm);
                }
            }
            return dst;
        }

        public void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var captured = ref skip(src,i);
                if(Decoder.Decode(captured, out var routine))
                    seek(dst,i) = new AsmRoutineCode(routine, captured, Formatter.Format(routine));
            }
        }

        public void Decode(ReadOnlySpan<ApiPartBlocks> src, Span<ApiPartRoutines> dst)
        {
            var hostFx = root.list<ApiHostRoutines>();
            var stats = ApiDecoderStats.init();
            var partCount = src.Length;
            var parts = src;
            var flow = Wf.Running(Msg.DecodingParts.Format(partCount));
            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();

                ref readonly var part = ref skip(parts,i);
                var hostBlocks = part.Blocks.View;
                var kHosts = hostBlocks.Length;
                if(kHosts == 0)
                {
                    seek(dst,i) = ApiPartRoutines.Empty;
                    continue;
                }

                var decoding = Wf.Running(Msg.DecodingPartRoutines.Format(kHosts, part.PartId));
                for(var j = 0; j<kHosts; j++)
                {
                    ref readonly var host = ref skip(hostBlocks,j);

                    if(host.IsEmpty)
                        continue;

                    var routines = Decode(host);
                    hostFx.Add(routines);
                    stats.HostCount++;
                    stats.MemberCount += routines.RoutineCount;
                    stats.InstructionCount += routines.InstructionCount;
                }

                seek(dst,i) = new ApiPartRoutines(part.PartId, hostFx.ToArray());

                Wf.Ran(decoding,  Msg.DecodedPartRoutines.Format(hostFx.Count, part.PartId, stats));
            }

            Wf.Ran(flow, Msg.DecodedMachine.Format(src.Length, parts.Length));
        }

        public Index<ApiPartRoutines> Decode(Index<ApiCodeBlock> src)
        {
            var hosts = src.ToHostBlocks();
            var parts = hosts.ToPartBlocks().View;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            Decode(parts, dst);

            return dst;
        }

        public ApiHostRoutines Decode(ApiHostBlocks src)
        {
            var host = src.Host;
            var flow = Wf.Running(Msg.DecodingHostRoutines.Format(host));
            var routines = DecodeRoutines(src);
            Wf.Ran(flow, Msg.DecodedHostRoutines.Format(routines.Length, host));
            return routines;
        }

        ApiHostRoutines DecodeRoutines(ApiHostBlocks src)
        {
            var host = src.Host;
            var view = src.Blocks.View;
            var count = view.Length;
            var instructions = root.list<ApiHostRoutine>();
            var ip = MemoryAddress.Zero;
            var target = root.list<IceInstruction>();
            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref skip(view,i);
                var decoded = Decoder.Decode(block, x => target.Add(x));
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