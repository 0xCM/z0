//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

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
                let block = asm.block(src.CodeBlock, i, src.TermCode)
                select routine(src.MetaUri, src.OpUri, src.Method.Metadata().DisplaySig, block);

        public Option<IceInstructionList> Decode(CodeBlock src)
            => Decode(src.Code, src.BaseAddress).TryMap(x => asm.list(x, src));

        public Option<AsmInstructionBlock> Decode(ApiCodeBlock src)
            => Decode(src.Encoded, src.BaseAddress);

        public Option<AsmRoutine> Decode(ApiCaptureBlock src, Action<Asm.IceInstruction> f)
            => Decode(src.Parsed,f).TryMap(x => routine(src,x));

        public Option<IceInstructionList> Decode(CodeBlock src, Action<Asm.IceInstruction> f)
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Code);
                var formatter = asm.formatter(AsmFormat);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                var @base = src.BaseAddress;
                decoder.IP = @base;
                var stop = false;
                var dst = new List<Asm.IceInstruction>(decoded.Count);

                while (reader.CanReadByte && !stop)
                {
                    ref var iced = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out iced);
                    var format = formatter.FormatInstruction(iced, @base);
                    var z = IceExtractors.extract(iced,format);
                    dst.Add(z);
                    f(z);
                }
                return asm.list(dst.ToArray(), src);

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

                var formatter = asm.formatter(AsmFormat);
                var instructions = new Asm.IceInstruction[decoded.Count];
                var formatted = formatter.FormatInstructions(decoded, @base);
                for(var i=0; i<instructions.Length; i++)
                    instructions[i] = IceExtractors.extract(decoded[i], formatted[i]);
                return AsmInstructionBlock.Create(instructions, code);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<AsmInstructionBlock>();
            }
        }

        public Option<IceInstructionList> Decode(ApiCodeBlock src, Action<IceInstruction> f)
            => Decode(new CodeBlock(src.BaseAddress,src.Data),f);

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
                info[i] = asm.summarize(@base, instruction, src.Encoded.Code, instruction.FormattedInstruction, offset);
                offset += (uint)instruction.ByteLength;
            }

            if(check)
                CheckBlockLength(src);

            return new AsmRoutine(meta, uri, sig, src.Encoded, src.TermCode, asm.list(src.Decoded, src.Encoded.Code));
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
    }
}