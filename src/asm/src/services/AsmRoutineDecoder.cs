//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    using Iced = Iced.Intel;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public class AsmRoutineDecoder : IAsmDecoder
    {
        readonly AsmFormatConfig AsmFormat;

        [MethodImpl(Inline)]
        public static AsmRoutineDecoder create(IWfRuntime wf)
            => new AsmRoutineDecoder(wf);

        [MethodImpl(Inline)]
        public AsmRoutineDecoder(IWfRuntime wf)
            => AsmFormat = AsmFormatConfig.@default(out var _);

        public Option<AsmRoutine> Decode(ApiCaptureBlock src)
        {
            var outcome = Decode(src, out var routine);
            if(outcome)
                return Option.some(routine);
            else
                return Option.none<AsmRoutine>();
        }

        public Outcome Decode(in ApiCaptureBlock src, out AsmRoutine dst)
        {
            dst = AsmRoutine.Empty;
            var outcome = Decode(src.OpUri, src.Parsed, src.BaseAddress, out var instructions);
            if(outcome)
            {
                var asm = apiblock(src.CodeBlock, instructions.InstructionStorage, src.TermCode);
                dst = routine(src.OpUri, src.Method.Artifact().DisplaySig, asm);
                return true;
            }
            return outcome;
        }

        public Outcome Decode(in CodeBlock src, out IceInstructionList dst)
        {
            var outcome = Decode(OpUri.Empty, src.Code, src.BaseAddress, out var block);
            if(outcome)
            {
                dst = icelist(block,src);
                return true;
            }
            else
            {
                dst = IceInstructionList.Empty;
                return outcome;
            }
        }

        public Outcome Decode(in ApiCodeBlock src, out AsmInstructionBlock dst)
            => Decode(src.OpUri, src.Encoded, src.BaseAddress, out dst);

        public Index<IceInstruction> Decode(BinaryCode code, MemoryAddress @base)
        {
            var decoded = new Iced.InstructionList();
            var reader = new Iced.ByteArrayCodeReader(code);
            var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = @base;
            while (reader.CanReadByte)
            {
                ref var instruction = ref decoded.AllocUninitializedElement();
                decoder.Decode(out instruction);
            }

            var count = decoded.Count;
            var formatter = iformatter(AsmFormat);
            var instructions = alloc<Asm.IceInstruction>(count);
            var formatted = formatter.FormatInstructions(decoded, @base);
            var position = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref decoded[i];
                var size = (uint)instruction.ByteLength;
                var encoded = slice(code.View, position, size).ToArray();
                instructions[i] = IceExtractors.extract(instruction, formatted[i], encoded);
                position += size;
            }
            return instructions;
        }

        public Outcome Decode(ApiCodeBlock src, Action<IceInstruction> f, out IceInstructionList dst)
            => Decode(src.OpUri, new CodeBlock(src.BaseAddress, src.Data), f, out dst);

        public Outcome Decode(in ApiMemberCode src, out AsmRoutine dst)
        {
            dst = AsmRoutine.Empty;
            var outcome = Decode(src.Encoded, out var block);
            if(outcome)
                dst = routine(src, block);
            return outcome;
        }

        Outcome Decode(OpUri uri, CodeBlock src, Action<Asm.IceInstruction> f, out IceInstructionList target)
        {
            target = IceInstructionList.Empty;
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Code);
                var formatter = iformatter(AsmFormat);
                var decoder = Iced.Decoder.Create(IntPtr.Size*8, reader);
                var @base = src.BaseAddress;
                decoder.IP = @base;
                var dst = root.list<Asm.IceInstruction>(decoded.Count);
                var position = 0u;
                while (reader.CanReadByte)
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced);
                    var size = (uint)iced.ByteLength;
                    var encoded = slice(src.View, position, size).ToArray();
                    var instruction = IceExtractors.extract(iced, formatter.FormatInstruction(iced, @base), encoded);
                    dst.Add(instruction);
                    f(instruction);
                    position += size;

                }
                target = icelist(dst.ToArray(), src);
                return true;
            }
            catch(Exception e)
            {
                return e;
            }
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

        static AsmRoutine routine(OpUri uri, MethodDisplaySig sig, ApiBlockAsm src, bool check = false)
        {
            var count = src.InstructionCount;
            var info = new AsmInstructionSummary[count];
            var offset = 0u;
            var @base = src.BaseAddress;

            for(var i=0; i<count; i++)
            {
                var instruction = src[i];
                if(check)
                    CheckInstructionSize(instruction, offset, src);
                info[i] = IceExtractors.summarize(@base, instruction, src.Encoded.Code, instruction.FormattedInstruction, offset);
                offset += (uint)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            return new AsmRoutine(uri, sig, src.Encoded, src.TermCode,  AsmEtl.ToApiInstructions(src.Encoded, src.Decoded));
        }

        static AsmRoutine routine(ApiMemberCode member, AsmInstructionBlock asm)
        {
            var code = new ApiCodeBlock(member.OpUri, member.Encoded);
            return new AsmRoutine(member.OpUri, member.Method.Artifact().DisplaySig, code, member.TermCode, AsmEtl.ToApiInstructions(code, asm));
        }

        [MethodImpl(Inline), Op]
        static IceInstructionList icelist(IceInstruction[] src, CodeBlock data)
            => new IceInstructionList(src, data);

        [MethodImpl(Inline), Op]
        static IIceInstructionFormatter iformatter(in AsmFormatConfig config)
            => new IceInstructionFormatter(config);

        [MethodImpl(Inline), Op]
        static ApiBlockAsm apiblock(ApiCodeBlock encoded, IceInstruction[] decoded, ExtractTermCode term)
            => new ApiBlockAsm(encoded, decoded, term);

        static void CheckInstructionSize(in IceInstruction instruction, uint offset, in ApiBlockAsm src)
        {
            if(src.Encoded.Length < offset + instruction.ByteLength)
                throw SizeMismatch(instruction, offset, src);
        }

        static void CheckBlockLength(in ApiBlockAsm src)
        {
            var blocklen = (uint)src.Decoded.Select(i => i.ByteLength).Sum();
            if(blocklen != src.Encoded.Length)
                throw BadBlockLength(src,blocklen);
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