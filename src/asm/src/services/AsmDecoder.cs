//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using Iced = Iced.Intel;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public class AsmDecoder : AppService<AsmDecoder>
    {
        readonly AsmFormatConfig AsmFormat;

        IceInstructionFormatter IceFormatter;

        public AsmDecoder()
        {
            AsmFormat = AsmFormatConfig.@default(out var _);
        }

        protected override void OnInit()
        {
            IceFormatter = formatter(AsmFormat);
        }

        public Outcome Decode(in CodeBlock src, out IceInstructions dst)
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var decoder = idecoder(src, src.BaseAddress, out var reader);
                var @base = src.BaseAddress;
                var buffer = list<Asm.IceInstruction>();
                var pos = 0u;
                while(reader.CanReadByte)
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced);
                    var size = (uint)iced.ByteLength;
                    var encoded = slice(src.View, pos, size).ToArray();
                    var instruction = extract(iced, IceFormatter.FormatInstruction(iced, @base), encoded);
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

                     instructions.Add(AsmRoutines.hosted(ip, block, target.ToArray()));
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
            var hostFx = list<ApiHostRoutines>();
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

        public ReadOnlySpan<ApiPartRoutines> Decode(ReadOnlySpan<ApiCodeBlock> src)
        {
            var hosts = ApiCodeBlocks.hosted(src);
            var parts = ApiCodeBlocks.parts(hosts);
            var count = parts.Length;
            var dst = alloc<ApiPartRoutines>(count);
            Decode(parts, dst);
            return dst;
        }

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
                dst = routine(src.OpUri, src.Method.Artifact().DisplaySig, asm);
                return true;
            }
            return outcome;
        }

        public Outcome Decode(in ApiCodeBlock src, out AsmInstructionBlock dst)
            => Decode(src.OpUri, src.Encoded, src.BaseAddress, out dst);

        public Index<IceInstruction> Decode(BinaryCode code, MemoryAddress @base)
        {
            var decoded = new Iced.InstructionList();
            var decoder = idecoder(code, @base, out var reader);
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
                seek(dst, i) = extract(instruction, skip(formatted,i), encoded);
                position += size;
            }
            return buffer;
        }

        public Outcome Decode(in ApiMemberCode src, out AsmRoutine dst)
        {
            dst = AsmRoutine.Empty;
            var outcome = Decode(src.Encoded, out var block);
            if(outcome)
                dst = AsmRoutines.routine(src, block);
            return outcome;
        }

        Outcome Decode(ApiCodeBlock src, Action<IceInstruction> f, out IceInstructionList dst)
            => Decode(src.OpUri, new CodeBlock(src.BaseAddress, src.Data), f, out dst);

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
                var buffer = list<Asm.IceInstruction>(decoded.Count);
                var position = 0u;
                while (reader.CanReadByte)
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced);
                    var size = (uint)iced.ByteLength;
                    var encoded = slice(src.View, position, size).ToArray();
                    var instruction = extract(iced, IceFormatter.FormatInstruction(iced, @base), encoded);
                    buffer.Add(instruction);
                    f(instruction);
                    position += size;

                }
                dst = icelist(buffer.ToArray(), src);
                return true;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        static IceInstruction extract(Iced.Instruction src, string formatted, BinaryCode decoded)
            => IceConverters.extract(src,formatted, decoded);

        [MethodImpl(Inline), Op]
        static IceInstructionList icelist(IceInstruction[] src, CodeBlock data)
            => new IceInstructionList(src, data);

        [MethodImpl(Inline), Op]
        static IceInstructionFormatter formatter(in AsmFormatConfig config)
            => new IceInstructionFormatter(config);

        static Iced.Decoder idecoder(BinaryCode code, MemoryAddress @base, out Iced.ByteArrayCodeReader reader)
        {
            reader = new Iced.ByteArrayCodeReader(code);
            var decoder =  Iced.Decoder.Create(64, reader);
            decoder.IP = @base;
            return decoder;
        }

        static AsmRoutine routine(OpUri uri, MethodDisplaySig sig, ApiBlockAsm src, bool check = false)
        {
            var count = src.InstructionCount;
            var buffer = new AsmInstructionInfo[count];
            var offset = 0u;
            var @base = src.BaseAddress;
            var instructions = src.Instructions;
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                var instruction = skip(instructions,i);
                if(check)
                    CheckInstructionSize(instruction, offset, src);
                seek(dst, i) = ApiInstructions.summarize(@base, instruction, src.Encoded.Code, instruction.FormattedInstruction, offset);
                offset += (uint)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            return new AsmRoutine(uri, sig, src.Encoded, src.TermCode, ApiInstructions.from(src.Encoded, src.Decoded));
        }

        static void CheckInstructionSize(in IceInstruction instruction, uint offset, in ApiBlockAsm src)
        {
            if(src.Encoded.Length < offset + instruction.ByteLength)
                core.@throw(SizeMismatch(instruction, offset, src));
        }

        static uint size(in ApiBlockAsm src)
        {
            var result = 0u;
            var instructions = src.Instructions;
            var count = instructions.Length;
            for(var i=0; i<count; i++)
                result += (uint)skip(instructions,i).ByteLength;
            return result;
        }

        static void CheckBlockLength(in ApiBlockAsm src)
        {
            var length = size(src);
            if(length != src.Encoded.Length)
                core.@throw(BadBlockLength(src,length));
        }

        static AppException BadBlockLength(in ApiBlockAsm src, uint computedLength)
            => new AppException(InstructionBlockSizeMismatch(src.BaseAddress, src.Encoded.Length, computedLength));

        static AppException SizeMismatch(in IceInstruction instruction, uint offset, in ApiBlockAsm src)
            => new AppException(InstructionSizeMismatch(instruction.IP, offset, (uint)src.Encoded.Length, (uint)instruction.ByteLength));

        static AppMsg InstructionSizeMismatch(MemoryAddress ip, uint offset, uint actual, uint reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.error(text.concat(
                    $"The encoded instruction length does not match the reported instruction length:",
                    $"address = {ip}, datalen = {reported}, offset = {offset}, bytelen = {reported}"),
                        caller, file, line);

        static AppMsg InstructionBlockSizeMismatch(MemoryAddress @base, int actual, uint reported,
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppMsg.error(text.concat(
                    $"The encoded instruction block length does not match the reported total instruction length:",
                    $"@base = {@base}, block length = {reported}, reported length = {reported}"),
                        caller, file, line);
    }
}