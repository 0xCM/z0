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
        public AsmRoutineDecoder(IWfRuntime wf)
            => AsmFormat = AsmFormatConfig.@default(out var _);

        public Option<AsmRoutine> Decode(ApiCaptureBlock src)
            => from i in Decode(src.OpUri, src.Parsed, src.BaseAddress)
                let block = apiblock(src.CodeBlock, i.InstructionStorage, src.TermCode)
                select routine(src.OpUri, src.Method.Artifact().DisplaySig, block);

        public Option<IceInstructionList> Decode(CodeBlock src)
            => Decode(OpUri.Empty, src.Code, src.BaseAddress).TryMap(x => icelist(x, src));

        public Option<AsmInstructionBlock> Decode(ApiCodeBlock src)
            => Decode(src.OpUri, src.Encoded, src.BaseAddress);

        public bool Decode(in ApiCodeBlock src, out AsmInstructionBlock dst)
        {
            var result = Decode(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = AsmInstructionBlock.Empty;
                return false;
            }
        }

        public Option<IceInstructionList> Decode(OpUri uri, CodeBlock src, Action<Asm.IceInstruction> f)
        {
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
                return icelist(dst.ToArray(), src);

            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<IceInstructionList>();
            }
        }

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

        public Option<AsmInstructionBlock> Decode(OpUri uri, BinaryCode code, MemoryAddress @base)
        {
            try
            {
                if(code.IsEmpty)
                {
                    term.warn("Supplied source was empty");
                    return Option.none<AsmInstructionBlock>();
                }

                return new AsmInstructionBlock(uri, Decode(code,@base), code);
            }
            catch(Exception e)
            {
                term.error(e);
                return root.none<AsmInstructionBlock>();
            }
        }

        public Option<IceInstructionList> Decode(ApiCodeBlock src, Action<IceInstruction> f)
            => Decode(src.OpUri, new CodeBlock(src.BaseAddress, src.Data), f);

        public Option<AsmRoutine> Decode(ApiMemberCode src)
        {
            var result = Decode(src.Encoded);
            if(result)
                return routine(src, result.Value);
            else
                return root.none<AsmRoutine>();
        }

        public bool Decode(ApiCaptureBlock src, out AsmRoutine dst)
        {
            var decoded = Decode(src);
            if(decoded)
            {
                dst = decoded.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
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