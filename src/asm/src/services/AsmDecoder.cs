//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    using api = AsmDecoderApi;
    using Iced = Iced.Intel;

    public class AsmDecoder : AppService<AsmDecoder>
    {
        readonly AsmFormatConfig AsmFormat;

        IAsmRoutineFormatter Formatter;

        IceInstructionFormatter IceFormatter;

        public AsmDecoder()
        {
            AsmFormat = AsmFormatConfig.@default(out var _);
            Formatter = new AsmRoutineFormatter(AsmFormat);
        }

        protected override void OnInit()
        {
            IceFormatter = api.iformatter(AsmFormat);
        }

        public Outcome Decode(in CodeBlock src, out IceInstructions dst)
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var decoder = api.decoder(src, src.BaseAddress, out var reader);
                var @base = src.BaseAddress;
                var buffer = list<Asm.IceInstruction>();
                var pos = 0u;
                while(reader.CanReadByte)
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced);
                    var size = (uint)iced.ByteLength;
                    var encoded = slice(src.View, pos, size).ToArray();
                    var instruction = IceExtractors.extract(iced, IceFormatter.FormatInstruction(iced, @base), encoded);
                    buffer.Add(instruction);
                    pos += size;

                }
                dst = new IceInstructions(buffer,src);
                return true;
            }
            catch(Exception e)
            {
                dst = IceInstructions.Empty;
                return e;
            }
        }
        public Option<AsmRoutine> Decode(ApiCaptureBlock src)
        {
            var outcome = Decode(src, out var routine);
            if(outcome)
                return Option.some(routine);
            else
                return Option.none<AsmRoutine>();
        }

        public ApiHostRoutines Decode(ApiHostBlocks src)
        {
            var host = src.Host;
            var flow = Wf.Running(Msg.DecodingHostRoutines.Format(host));
            var view = src.Blocks.View;
            var count = view.Length;
            var instructions = core.list<ApiHostRoutine>();
            var ip = MemoryAddress.Zero;
            var target = core.list<IceInstruction>();
            for(var i=0; i<count; i++)
            {
                target.Clear();
                ref readonly var block = ref skip(view,i);
                var outcome = Decode(block, x => target.Add(x), out var decoded);
                if(outcome)
                {
                    if(i == 0)
                        ip = target[0].IP;

                     instructions.Add(AsmEtl.ApiHostRoutine(ip, block, target.ToArray()));
                }
                else
                    Wf.Warn(outcome.Message);
            }

            var routines = new ApiHostRoutines(host, instructions.ToArray());
            Wf.Ran(flow, Msg.DecodedHostRoutines.Format(routines.Length, host));
            return routines;
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

        public ReadOnlySpan<ApiPartRoutines> Decode(ReadOnlySpan<ApiCodeBlock> src)
        {
            var hosts = src.ToHostBlocks();
            var parts = hosts.ToPartBlocks();
            var count = parts.Length;
            var dst = alloc<ApiPartRoutines>(count);
            Decode(parts, dst);
            return dst;
        }

        // public ReadOnlySpan<AsmRoutineCode> Decode(ReadOnlySpan<ApiCaptureBlock> src, FS.FilePath dst)
        // {
        //     var count = src.Length;
        //     var buffer = span<AsmRoutineCode>(count);
        //     using var writer = dst.Writer();
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var captured = ref skip(src,i);
        //         if(Decode(captured, out var routine))
        //         {
        //             var asm = Formatter.Format(routine).Content;
        //             seek(buffer,i) = new AsmRoutineCode(routine,captured, asm);
        //             writer.Write(asm);
        //         }
        //     }
        //     return buffer;
        // }

        // public void Decode(ReadOnlySpan<ApiCaptureBlock> src, Span<AsmRoutineCode> dst)
        // {
        //     var count = src.Length;
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var captured = ref skip(src,i);
        //         if(Decode(captured, out var routine))
        //             seek(dst,i) = new AsmRoutineCode(routine, captured, Formatter.Format(routine).Content);
        //     }
        // }

        public AsmHostRoutines Decode(ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            try
            {
                var flow = Wf.Running(uri);
                var count = src.Length;
                var buffer = alloc<AsmMemberRoutine>(count);
                ref var dst = ref first(buffer);
                for(var i=0; i<count; i++)
                {
                    ref readonly var code = ref skip(src, i);
                    var outcome = Decode(code, out var decoded);
                    if(!outcome)
                    {
                        Wf.Error($"Could not decode {code}");
                        seek(dst,i) = AsmMemberRoutine.Empty;
                    }
                    else
                        seek(dst, i) = new AsmMemberRoutine(code.Member, decoded);
                }

                Wf.Ran(flow, Msg.DecodedHostMembers.Format(buffer.Length, uri));
                return buffer;
            }
            catch(Exception e)
            {
                Wf.Error($"{uri}: {e}");
                return sys.empty<AsmMemberRoutine>();
            }
        }

        public Outcome Decode(in ApiCaptureBlock src, out AsmRoutine dst)
        {
            dst = AsmRoutine.Empty;
            var outcome = Decode(src.OpUri, src.Parsed, src.BaseAddress, out var instructions);
            if(outcome)
            {
                var asm = new ApiBlockAsm(src.CodeBlock, instructions.InstructionStorage, src.TermCode);
                dst = api.routine(src.OpUri, src.Method.Artifact().DisplaySig, asm);
                return true;
            }
            return outcome;
        }

        // public Outcome Decode(in CodeBlock src, out IceInstructionList dst)
        // {
        //     var outcome = Decode(OpUri.Empty, src.Code, src.BaseAddress, out var block);
        //     if(outcome)
        //     {
        //         dst = api.icelist(block,src);
        //         return true;
        //     }
        //     else
        //     {
        //         dst = IceInstructionList.Empty;
        //         return outcome;
        //     }
        // }

        public Outcome Decode(in ApiCodeBlock src, out AsmInstructionBlock dst)
            => Decode(src.OpUri, src.Encoded, src.BaseAddress, out dst);

        public Index<IceInstruction> Decode(BinaryCode code, MemoryAddress @base)
        {
            var decoded = new Iced.InstructionList();
            var decoder = api.decoder(code, @base, out var reader);
            while (reader.CanReadByte)
            {
                ref var instruction = ref decoded.AllocUninitializedElement();
                decoder.Decode(out instruction);
            }

            var count = decoded.Count;
            var buffer = alloc<Asm.IceInstruction>(count);
            ref var dst = ref first(buffer);
            var formatted = IceFormatter.FormatInstructions(decoded, @base);
            var position = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref decoded[i];
                var size = (uint)instruction.ByteLength;
                var encoded = slice(code.View, position, size).ToArray();
                seek(dst, i) = IceExtractors.extract(instruction, skip(formatted,i), encoded);
                position += size;
            }
            return buffer;
        }

        public Outcome Decode(ApiCodeBlock src, Action<IceInstruction> f, out IceInstructionList dst)
            => Decode(src.OpUri, new CodeBlock(src.BaseAddress, src.Data), f, out dst);

        public Outcome Decode(in ApiMemberCode src, out AsmRoutine dst)
        {
            dst = AsmRoutine.Empty;
            var outcome = Decode(src.Encoded, out var block);
            if(outcome)
                dst = AsmEtl.routine(src, block);
            return outcome;
        }

        Outcome Decode(OpUri uri, BinaryCode code, MemoryAddress @base, out AsmInstructionBlock dst)
        {
            dst = AsmInstructionBlock.Empty;
            if(code.IsEmpty)
                return (false,"Supplied source was empty");
            else
            {
                dst = new AsmInstructionBlock(uri, Decode(code,@base), code);
                return true;
            }
        }

        Outcome Decode(OpUri uri, CodeBlock src, Action<Asm.IceInstruction> f, out IceInstructionList dst)
        {
            dst = IceInstructionList.Empty;
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Code);
                var decoder = Iced.Decoder.Create(IntPtr.Size*8, reader);
                var @base = src.BaseAddress;
                decoder.IP = @base;
                var buffer = core.list<Asm.IceInstruction>(decoded.Count);
                var position = 0u;
                while (reader.CanReadByte)
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced);
                    var size = (uint)iced.ByteLength;
                    var encoded = slice(src.View, position, size).ToArray();
                    var instruction = IceExtractors.extract(iced, IceFormatter.FormatInstruction(iced, @base), encoded);
                    buffer.Add(instruction);
                    f(instruction);
                    position += size;

                }
                dst = api.icelist(buffer.ToArray(), src);
                return true;
            }
            catch(Exception e)
            {
                return e;
            }
        }


    }
}