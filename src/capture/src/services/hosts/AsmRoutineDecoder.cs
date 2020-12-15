//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    using Iced = Iced.Intel;

    readonly struct AsmRoutineDecoder : IAsmDecoder
    {
        readonly AsmFormatConfig AsmFormat;

        [MethodImpl(Inline)]
        public AsmRoutineDecoder(in AsmFormatConfig format)
            => AsmFormat = format;

        public Option<AsmRoutine> Decode(ApiCaptureBlock src)
            => from i in Decode(src.Parsed)
                let block = asm.block(src.UriHex, i, src.TermCode)
                select ApiAsm.routine(src.MetaUri, src.OpUri, src.Method.Metadata().Format(), block);

        public Option<AsmFxList> Decode(BasedCodeBlock src)
            => Decode(src.Encoded, src.Base).TryMap(x => asm.list(x, src));

        public Option<AsmInstructions> Decode(ApiCodeBlock src)
            => Decode(src.Encoded, src.Base);

        public Option<AsmRoutine> Decode(ApiCaptureBlock src, Action<Asm.Instruction> f)
            => Decode(src.Parsed,f).TryMap(x => ApiAsm.routine(src,x));

        public Option<AsmFxList> Decode(BasedCodeBlock src, Action<Asm.Instruction> f)
        {
            try
            {
                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(src.Encoded);
                var formatter = Capture.formatter(AsmFormat);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                var @base = src.Base;
                decoder.IP = @base;
                var stop = false;
                var dst = new List<Asm.Instruction>(decoded.Count);

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
                return Option.none<AsmFxList>();
            }
        }

        public Option<AsmInstructions> Decode(BinaryCode code, MemoryAddress @base)
        {
            try
            {
                if(code.IsEmpty)
                {
                    term.warn("Supplied source was empty");
                    return Option.none<AsmInstructions>();
                }

                var decoded = new Iced.InstructionList();
                var reader = new Iced.ByteArrayCodeReader(code.Encoded);
                var decoder = Iced.Decoder.Create(IntPtr.Size * 8, reader);
                decoder.IP = @base;
                while (reader.CanReadByte)
                {
                    ref var instruction = ref decoded.AllocUninitializedElement();
                    decoder.Decode(out instruction);
                }

                var formatter = Capture.formatter(AsmFormat);
                var instructions = new Asm.Instruction[decoded.Count];
                var formatted = formatter.FormatInstructions(decoded, @base);
                for(var i=0; i<instructions.Length; i++)
                    instructions[i] = IceExtractors.extract(decoded[i], formatted[i]);
                return AsmInstructions.Create(instructions, code);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<AsmInstructions>();
            }
        }

        public Option<AsmFxList> Decode(ApiCodeBlock src, Action<Instruction> f)
        {
            var x86 = new BasedCodeBlock(src.Base,src.Data);
            return Decode(x86,f);
        }

        public Option<AsmRoutine> Decode(ApiMemberCode src)
        {
            var result = Decode(src.Encoded);
            if(result)
                return ApiAsm.routine(src, result.Value);
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
    }
}