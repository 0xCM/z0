//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    using Iced = Iced.Intel;

    readonly struct AsmRoutineDecoder : IAsmDecoder
    {
        readonly AsmFormatSpec AsmFormat;

        public static AsmRoutineDecoder Default
        {
            [MethodImpl(Inline)]
            get => new AsmRoutineDecoder(AsmFormatSpec.Default);
        }

        [MethodImpl(Inline)]
        public AsmRoutineDecoder(in AsmFormatSpec format)
            => AsmFormat = format;

        public Option<AsmRoutine> Decode(X86ApiCapture src)
            => from i in Decode(src.Parsed)
                let block = asm.block(src.UriHex, i, src.TermCode)
                select AsmServices.routine(src.OpUri, src.Method.Signature().Format(), block);

        public Option<AsmFxList> Decode(X86Code src)
            => Decode(src.Encoded, src.Base).TryMap(x => asm.list(x, src));

        public Option<AsmInstructions> Decode(X86UriHex src)
            => Decode(src.Encoded, src.Base);

        public Option<AsmRoutine> Decode(X86ApiCapture src, Action<Asm.Instruction> f)
            => Decode(src.Parsed,f).TryMap(x => AsmServices.routine(src,x));

        public Option<AsmFxList> Decode(X86Code src, Action<Asm.Instruction> f)
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

        Option<AsmInstructions> Decode(BinaryCode code, MemoryAddress @base)
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
                return Option.none<AsmInstructions>();
            }
        }

        public Option<AsmFxList> Decode(X86UriHex src, Action<Instruction> f)
        {
            var x86 = new X86Code(src.Base,src.Data);
            return Decode(x86,f);
        }

        public Option<AsmFxList> Decode(X86ApiCode src, Action<Instruction> f)
        {
            var x86 = new X86Code(src.Base, src.Data);
            return Decode(x86,f);
        }

        public Option<AsmRoutine> Decode(X86ApiMember src)
            => from i in Decode(src.Encoded) select AsmServices.routine(src,i);
    }
}