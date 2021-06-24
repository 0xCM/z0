//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Root;
    using static core;
    using static AsmSemanticDefaults;
    using static IceOpKind;

    [ApiHost]
    public readonly struct AsmSemanticRender
    {
        [MethodImpl(Inline), Op]
        public static AsmSemanticRender create(IWfRuntime wf)
            => new AsmSemanticRender(wf);

        readonly IWfRuntime Wf;

        readonly HexFormatOptions DataFormat;

        readonly List<string> Buffer;

        internal AsmSemanticRender(IWfRuntime wf)
        {
            Wf = wf;
            Buffer = root.list<string>();
            DataFormat = HexFormatSpecs.HexData;
        }

        public void Render(ReadOnlySpan<ApiPartRoutines> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Render(skip(src,i));
        }

        public void Render(in ApiPartRoutines src)
        {
            var flow = Wf.Running(string.Format("Render semantic for <{0}> running", src.Part));
            var part = src.Part;
            var dst = AsmSemanticArchive.create(Wf);
            var dir = dst.SemanticDir(part).Clear();
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                Buffer.Clear();
                ref readonly var routines = ref skip(view,i);
                var path = dst.SemanticPath(routines.Uri);
                var emitting = Wf.EmittingFile(path);
                Emit(routines, path);
                Wf.EmittedFile(emitting, routines.RoutineCount);
            }
            Wf.Ran(flow, string.Format("Render semantic for <{0}> completed", src.Part));
        }

        void Emit(in ApiHostRoutines src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            Render(src, writer);
        }

        [Op]
        void Render(ApiHostRoutines src, StreamWriter dst)
        {
            var functions = src.Members.View;
            var count = src.RoutineCount;
            var offset = MemoryAddress.Zero;
            for(var i=0; i<count; i++)
            {
                Render(skip(functions,i), dst, ref offset);
                if(i != count - 1)
                    dst.WriteLine();
            }
        }

        [Op]
        void Render(ApiHostRoutine src, StreamWriter dst, ref MemoryAddress offset)
        {
            Buffer.Clear();
            Buffer.Add(src.OpId);
            Buffer.Add(SectionSep);

            var sequence = AsmOffsetSeq.Zero;
            var @base = src.BaseAddress;
            var address = @base;
            var instructions = src.Instructions.View;
            var count = src.InstructionCount;

            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions,i);
                var size = instruction.InstructionSize;
                Render(instruction, address, offset, sequence);
                address += size;
                offset += size;
                sequence = sequence.AccrueOffset(size);
            }

            render(Buffer.ToArray(), dst);
        }

        [Op]
        static string format(MemoryAddress @base, IceInstruction src, byte i)
        {
            var kind = IceConverters.opkind(src, i);
            var desc = EmptyString;
            if(IceOpTest.isRegister(kind))
                desc = format(IceConverters.register(src,i));
            else if(IceOpTest.isMem(kind))
                desc = format(IceConverters.meminfo(src, i));
            else if (IceOpTest.isBranch(kind))
                desc = AsmRender.format(IceConverters.branch(@base, src, i));
            else if(IceOpTest.isImm(kind))
                desc = AsmRender.format(IceConverters.imminfo(src, i));
            else
                desc = kind.ToString();

            return desc;
        }

        [Op]
        string Format(BinaryCode src)
            => src.Storage.FormatHex(DataFormat);

        [Op]
        void Render(ApiInstruction src, MemoryAddress address, MemoryAddress offset, AsmOffsetSeq seq)
        {
            var @base = address;
            var fx = src.Instruction;
            var encoded = Format(src.Encoded);
            var location = LineLocation(fx, address, offset, seq);
            var header = InstructionHeader(src, address, offset, seq);
            Buffer.Add(header);

            var opcount = src.Instruction.OpCount;
            var summaries = root.list<string>();
            for(byte i =0; i<opcount; i++)
            {
                var kind = IceConverters.opkind(fx, i);
                var col01 = i.ToString().PadLeft(SeqDigitPad,'0').PadRight(SubColPad);
                var kindLabel = Render(kind).PadRight(OpKindPad);
                var col02 = string.Concat(col01, ColSep, kindLabel, Chars.Pipe, Chars.Space);
                summaries.Add(col02 + format(@base, fx, i));
            }

            foreach(var s in summaries)
                Buffer.Add(string.Concat(location, ColSep, $"{s}"));


             var fc = footer(src);
             if(nonempty(fc))
                Buffer.Add(string.Concat(location, ColSep, fc));

            Buffer.Add(string.Concat(location, ColSep, InstructionSep));
        }

        [Op]
        string InstructionHeader(ApiInstruction src, MemoryAddress address, MemoryAddress offset,  AsmOffsetSeq seq)
        {
            var left = LineLocation(src.Instruction, address, offset, seq);
            var right = string.Concat(src.Statment, SpecifierSep, src.AsmForm.Format(), EncodingSep, Format(src.Encoded));
            return string.Concat(left, ColSep, right);
        }

        [Op]
        static string LineLocation(IceInstruction src, MemoryAddress address, MemoryAddress offset, AsmOffsetSeq seq)
            => string.Concat(FormatAddress(src, AddressPad),
                string.Concat(RP.spaced(offset)).PadRight(OffsetAddrPad),
                seq.Format(InstructionCountPad));

        [Op]
        static string format(IceRegister src)
            => string.Format("{0}",src);

        [Op, MethodImpl(NotInline)]
        static string format(IceOpKind src)
        {
            var si = FormatSegKind(src);
            if(text.nonempty(si))
                return si;

            var result = src switch{
		    IceOpKind.Register => "register",
            NearBranch16 => "branch16",
		    NearBranch32 => "branch32",
		    NearBranch64 => "branch64",
            FarBranch16 => "farbranch16",
            FarBranch32 => "farbranch32",
            Immediate8 => "imm8",
            Immediate8_2nd => "imm8x2",
            Immediate16 => "imm16",
            Immediate32 => "imm32",
            Immediate64 => "imm64",
            Immediate8to16 => "imm16i",
            Immediate8to32 => "imm32i",
            Immediate8to64 => "imm64i",
            Immediate32to64 => "imm32x64i",
            Memory64 => "mem64",
            Memory => "mem",
                _ => src.ToString()
            };

            return result;
        }

        [Op]
        static string Render(IceOpKind src)
            => format(src);

        [Op]
        static string format(IceMemDirect src)
        {
            var dst = text.build();
            if(src.Base.IsSome())
                dst.Append(format(src.Base));
            else
                dst.Append("UNK");

            if(src.Scale.IsNonUnital && src.Scale.IsNonZero)
            {
                var scale = src.Scale.Format();
                dst.Append(text.concat(Chars.Star, scale));
            }

            if(src.Dx.NonZero)
                dst.Append(string.Concat(Chars.Space, Chars.Plus, Chars.Space, AsmRender.format(src.Dx)));

            return dst.ToString();
        }

        [Op]
        static string FormatSegKind(Name name)
            => name.IsEmpty ? EmptyString : string.Concat("seg:", Chars.LBracket, name, Chars.RBracket);

        /// <summary>
        /// If operand kind represents a memory segment, returns the mnemonic/name for the segment; otheriwise returns empty
        /// </summary>
        /// <param name="src"></param>
        [Op]
        public static Name segname(IceOpKind src)
            => src switch {
                MemorySegSI => "si",
                MemorySegESI => "esi",
                MemorySegRSI => "rsi",
                MemorySegDI => "di",
                MemorySegEDI => "edi",
                MemorySegRDI => "rdi",
                MemoryESDI => "esdi",
                MemoryESEDI => "esedi",
                MemoryESRDI => "esrdi",
            _ => Name.Empty
            };

        [Op]
        static string FormatSegKind(IceOpKind src)
            => FormatSegKind(segname(src));

        [Op]
        static string FormatAddress(IceInstruction src, int pad = 16)
            => text.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        [Op]
        static string footer(ApiInstruction src)
        {
            if(IceOpTest.isCall(src.Instruction))
            {
                var bytes = span(src.Encoded.Data);
                if(bytes.Length >= 5)
                {
                    var encoded = bytes.Slice(1,4);
                    var offset = encoded.TakeUInt32();
                    var target = src.NextIp + offset;
                    var delta = target - src.IP;
                    return text.concat(delta.FormatMinimal(), " | ", offset.FormatAsmHex(), " | ", target.Format());
                }
            }

            return EmptyString;
        }

        [Op]
        static string format(IceMemorySize src)
            => IceConverters.identify(src).Format();

        static StringBuilder Render(IceMemoryInfo src, StringBuilder builder)
        {
            var nonempty = false;
            if(!src.IsEmpty)
            {
                var s = format(src.Direct);
                if(text.nonempty(s))
                {
                    builder.Append(s);
                    nonempty = true;
                }
            }

            if(src.Address.IsNonEmpty)
            {
                builder.Append(src.Address.Format());
                nonempty = true;
            }

            if(src.HasKnownSize && nonempty)
            {
                builder.Append(Chars.Colon);
                builder.Append(format(src.Size));
            }
            return builder;
        }


        [Op]
        static string format(IceMemoryInfo src)
            => Render(src, text.build()).ToString();

        static void render(ReadOnlySpan<string> src, StreamWriter dst)
        {
            var count = src.Length;
            for(var j=0; j<count; j++)
                dst.WriteLine(skip(src,j));
        }
    }
}