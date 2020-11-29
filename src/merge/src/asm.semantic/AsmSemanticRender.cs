//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Asm;

    using static Konst;
    using static z;
    using static AsmRenderPatterns;
    using static Z0.Asm.OpKind;

    [ApiHost(ApiNames.AsmSemanticRender, true)]
    public readonly struct AsmSemanticRender : IDisposable
    {
        [MethodImpl(Inline), Op]
        public static AsmSemanticRender create(IWfShell wf)
            => new AsmSemanticRender(wf);

        readonly IWfShell Wf;

        readonly HexFormatOptions DataFormat;

        readonly List<string> Buffer;

        [MethodImpl(Inline)]
        public AsmSemanticRender(IWfShell wf)
        {
            Wf = wf;
            Buffer = list<string>();
            DataFormat = HexFormatSpecs.HexData;
        }


        public void Dispose()
        {

        }

        public void Render(in ApiPartRoutines src)
            => Execute(src);

        [MethodImpl(Inline), Op]
        public static ISemanticArchive semantic(IWfShell wf)
            => AsmSemanticArchive.create(wf);

        [Op, MethodImpl(NotInline)]
        void Execute(in ApiPartRoutines src)
        {
            var part = src.Part;
            var dst = semantic(Wf);
            var dir = dst.SemanticDir(part).Clear();
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                Buffer.Clear();
                ref readonly var host = ref skip(view,i);
                var path = dst.SemanticPath(host.Uri);
                using var writer = path.Writer();
                Render(host, writer);
            }
        }


        [Op, MethodImpl(NotInline)]
        void Render(ApiHostRoutines src, StreamWriter dst)
        {
            var functions = span(src.Routines);
            var count = src.RoutineCount;
            var offset = MemoryAddress.Empty;

            for(var i=0; i<count; i++)
            {
                Render(skip(functions,i), dst, ref offset);

                if(i != count - 1)
                    dst.WriteLine();
            }
        }

        [Op, MethodImpl(NotInline)]
        void Render(ApiRoutineObsolete src, StreamWriter dst, ref MemoryAddress offset)
        {
            Buffer.Clear();

            Buffer.Add(src.OpId);
            Buffer.Add(SectionSep);

            var sequence = OffsetSequence.Zero;
            var @base = src.OffsetAddress.Base;
            var address = @base;
            var instructions = src.Instructions.View;
            var count = src.InstructionCount;

            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions,i);
                var size = (uint)instruction.Size;
                Render(instruction, address, offset, sequence);
                address += size;
                offset += size;
                sequence = sequence.AccrueOffset(size);
            }

            var rendered = Buffer.ToArray();
            for(var j=0; j<rendered.Length; j++)
                dst.WriteLine(rendered[j]);
        }

        [Op, MethodImpl(NotInline)]
        string FormatMemory(MemoryAddress @base, Instruction src, byte i)
            => Render(asm.meminfo(src, i));

        [Op, MethodImpl(NotInline)]
        string Format(MemoryAddress @base, Instruction src, byte i)
        {
            var kind = asm.kind(src, i);
            var desc = kind.ToString();

            if(asm.isRegister(kind))
                desc = Render(asm.register(src,i));
            else if(asm.isMem(kind))
                desc = FormatMemory(@base, src, i);
            else if (asm.isBranch(kind))
                desc = Render(asm.branch(@base, src, i));
            else if(asm.isImm(kind))
                desc = Render(asm.imminfo(src, i));

            return desc;
        }

        [Op, MethodImpl(NotInline)]
        string Format(BinaryCode src)
            => text.concat("encoded", text.bracket(src.Length), Assign, src.Data.FormatHexBytes(DataFormat));

        [Op, MethodImpl(NotInline)]
        string Footer(ApiInstruction src)
        {
            if(asm.isCall(src.Instruction))
            {
                var bytes = z.span(src.Encoded.Data);
                if(bytes.Length >= 5)
                {
                    var encoded = bytes.Slice(1,4);
                    var offset = encoded.TakeUInt32();
                    var target = src.NextIp + offset;
                    var delta = target - src.IP;
                    return text.concat(delta.FormatMinimal(), " | ", offset.FormatAsmHex(), " | ", target.Format());
                }
            }

            return string.Empty;
        }

        [Op, MethodImpl(NotInline)]
        void Render(ApiInstruction src, MemoryAddress address, MemoryAddress offset, OffsetSequence seq)
        {
            var @base = src.Base;
            var fx = src.Instruction;
            var encoded = Format(src.Encoded);
            var location = LineLocation(fx, address, offset, seq);
            var header = InstructionHeader(src, address, offset, seq);
            Buffer.Add(header);

            var opcount = src.Instruction.OpCount;
            var summaries = z.list<string>();
            for(byte i =0; i<opcount; i++)
            {
                var kind = asm.kind(fx, i);
                var col01 = i.ToString().PadLeft(SeqDigitPad,'0').PadRight(Col0Pad);
                var kindLabel = Render(kind).PadRight(OpKindPad);
                var col03 = text.concat(col01, ColSep, kindLabel, Chars.Pipe, Chars.Space);
                var desc = Format(@base, fx, (byte)i);

                summaries.Add(col03 + desc);
            }

            foreach(var s in summaries)
                Buffer.Add(text.concat(location, ColSep, $"{s}"));


             var fc = Footer(src);
             if(text.nonempty(fc))
             {
                var footer = text.concat(location, ColSep, fc);
                Buffer.Add(footer);
             }

            Buffer.Add(DelimitInstruction(location));
        }

        [Op, MethodImpl(NotInline)]
        string DelimitInstruction(string location)
            => text.concat(location, ColSep, FxDelimiter);

        [Op, MethodImpl(NotInline)]
        string LineLocation(Instruction src, MemoryAddress address, MemoryAddress offset, OffsetSequence seq)
            => text.concat(RenderAddress(src, AddressPad),
                Z0.Render.concat(text.spaced(offset)).PadRight(OffsetAddrPad),
                seq.Format(InstructionCountPad));

        [Op, MethodImpl(NotInline)]
        string InstructionHeader(ApiInstruction src, MemoryAddress address, MemoryAddress offset,  OffsetSequence seq)
        {
            var left = LineLocation(src.Instruction, address, offset, seq);
            var right = text.concat(src.FormattedInstruction, LeftImply, src.InstructionCode, HeaderSep, Format(src.Encoded));
            return text.concat(left, ColSep, right);
        }

        [Op, MethodImpl(Inline)]
        static string format(MemoryAddress src)
            => string.Format("{0:x}" + HexFormatSpecs.PostSpec, src);

        [Op, MethodImpl(NotInline)]
        static string Render(AsmBranch src)
            => text.concat(format(src.Source), " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

        static HexFormatOptions HexSpec
        {
            [MethodImpl(Inline), Op]
            get => HexFormatSpecs.options(zpad:false, specifier:false);
        }

        [Op, MethodImpl(NotInline)]
        static string format(in MemDx src)
            => (src.Size switch{
                MemDxSize.y1 => ((byte)src.Value).FormatHex(HexSpec),
                MemDxSize.y2 => ((ushort)src.Value).FormatHex(HexSpec),
                MemDxSize.y4 => ((uint)src.Value).FormatHex(HexSpec),
                _ => (src.Value).FormatHex(HexSpec),
            }) + "dx";

        [Op, MethodImpl(NotInline)]
        static string format(in ImmInfo src)
            => Z0.Render.concat(src.Value.FormatHex(zpad:false, prespec:false));

        [Op, MethodImpl(NotInline)]
        static string Render(IceRegister src)
            => text.format("{0}",src);

        [Op, MethodImpl(NotInline)]
        static string Render(in ImmInfo src)
            => format(src);

        [Op, MethodImpl(NotInline)]
        static string Render(MemDx src)
            => format(src);

        [Op, MethodImpl(NotInline)]
        static string format(OpKind src)
        {
            var si = RenderSegKind(src);
            if(text.nonempty(si))
                return si;

            var result = src switch{
		    OpKind.Register => "register",
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

        [Op, MethodImpl(NotInline)]
        static string Render(OpKind src)
            => format(src);

        [Op, MethodImpl(NotInline)]
        static string Render(MemDirect src)
        {
            var dst = text.build();
            if(src.Base.IsSome())
                dst.Append(Render(src.Base));
            else
                dst.Append("UNK");

            if(src.Scale.NonUnital && src.Scale.NonZero)
            {
                var scale = Render(src.Scale);
                dst.Append(text.concat(Chars.Star, scale));
            }

            if(src.Dx.NonZero)
                dst.Append(text.concat(Chars.Space, Chars.Plus, Chars.Space, Render(src.Dx)));

            return dst.ToString();
        }

        [Op, MethodImpl(NotInline)]
        static string RenderSegKind(string symbol)
            => text.blank(symbol) ? EmptyString : text.concat("seg:", Chars.LBracket, symbol, Chars.RBracket);

        [Op, MethodImpl(NotInline)]
        static string RenderSegKind(OpKind src)
            => RenderSegKind(src switch {
                MemorySegDI => "di",
                MemorySegEDI => "edi",
                MemorySegESI => "esi",
                MemorySegRDI => "rdi",
                MemorySegRSI => "rsi",
                MemorySegSI => "si",
                MemoryESDI => "esdi",
                MemoryESEDI => "esedi",
                MemoryESRDI => "esrdi",
            _ => ""
            });

        [Op, MethodImpl(NotInline)]
        static string RenderAddress(Instruction src, int pad = 16)
            => Z0.Render.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        [Op, MethodImpl(NotInline)]
        static string Render(MemorySize src)
            => asm.identify(src).Format();

        [Op, MethodImpl(NotInline)]
        static string Render(MemInfo src)
        {
            var builder = text.build();

            var nonempty = false;
            if(!src.IsEmpty)
            {
                var s = Render(src.Direct);
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
                builder.Append(Render(src.Size));
            }

            return builder.ToString();
        }

        [Op, MethodImpl(NotInline)]
        static string Render(MemScale src)
        {
            if(src.IsNonEmpty)
                return src.Value.ToString();
            else
                return string.Empty;
        }
    }
}