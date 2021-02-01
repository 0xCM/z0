//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmFxCheck;
    using static z;

    using Iced = Iced.Intel;

    readonly struct AsmRoutineDecoder : IAsmDecoder
    {
        readonly AsmFormatConfig AsmFormat;

        [MethodImpl(Inline)]
        public AsmRoutineDecoder(AsmFormatConfig format)
            => AsmFormat = format;

        public Option<AsmRoutine> Decode(ApiCaptureBlock src)
            => from i in Decode(src.Parsed)
                let block = apiblock(src.CodeBlock, i.Storage, src.TermCode)
                select routine(src.MetaUri, src.OpUri, src.Method.Metadata().DisplaySig, block);

        public Option<IceInstructionList> Decode(CodeBlock src)
            => Decode(src.Code, src.BaseAddress).TryMap(x => icelist(x, src));

        public Option<AsmInstructionBlock> Decode(ApiCodeBlock src)
            => Decode(src.Encoded, src.BaseAddress);

        public Option<IceInstructionList> Decode(CodeBlock src, Action<Asm.IceInstruction> f)
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

        public Option<AsmInstructionBlock> Decode(BinaryCode code, MemoryAddress @base)
        {
            try
            {
                if(code.IsEmpty)
                {
                    term.warn("Supplied source was empty");
                    return Option.none<AsmInstructionBlock>();
                }

                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(code.Storage);
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
                return new AsmInstructionBlock(instructions, code);
            }
            catch(Exception e)
            {
                term.error(e);
                return root.none<AsmInstructionBlock>();
            }
        }

        public Option<IceInstructionList> Decode(ApiCodeBlock src, Action<IceInstruction> f)
            => Decode(new CodeBlock(src.BaseAddress, src.Data), f);

        public Option<AsmRoutine> Decode(ApiMemberCode src)
        {
            var result = Decode(src.Encoded);
            if(result)
                return routine(src, result.Value);
            else
                return none<AsmRoutine>();
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

        static AsmRoutine routine(ApiArtifactUri meta, OpUri uri, ClrDisplaySig sig, ApiBlockAsm src, bool check = false)
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

            return new AsmRoutine(meta, uri, sig, src.Encoded, src.TermCode, icelist(src.Decoded, src.Encoded.Code));
        }

        static AsmRoutine routine(ApiCaptureBlock captured, IceInstructionList src)
        {
            var code = new ApiCodeBlock(captured.OpUri, captured.Parsed);
            return new AsmRoutine(captured.MetaUri, captured.OpUri, captured.Method.Metadata().DisplaySig, code, captured.TermCode, src);
        }

        static AsmRoutine routine(ApiMemberCode member, AsmInstructionBlock asm)
        {
            var code = new ApiCodeBlock(member.OpUri, member.Encoded);
            return new AsmRoutine(member.MetaUri, member.OpUri, member.Method.Metadata().DisplaySig, code, member.TermCode, new IceInstructionList(asm, member.Encoded));
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
    }
}