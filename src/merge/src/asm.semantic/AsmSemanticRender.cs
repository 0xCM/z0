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
    using System.Text;

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

        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly HexFormatOptions DataFormat;

        readonly List<string> Buffer;

        [MethodImpl(Inline)]
        public AsmSemanticRender(IWfShell wf)
        {
            Host = WfShell.host(typeof(AsmSemanticRender));
            Wf = wf.WithHost(Host);
            Buffer = list<string>();
            DataFormat = HexFormatSpecs.HexData;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Render(in ApiPartRoutines src)
        {
            using var run = Wf.Running(string.Format("Running {0} semantic render", src.Part));
            Execute(src);
        }


        [Op]
        void Execute(in ApiPartRoutines src)
        {
            var part = src.Part;
            var dst = AsmSemanticArchive.create(Wf);
            var dir = dst.SemanticDir(part).Clear();
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                Buffer.Clear();
                ref readonly var routines = ref skip(view,i);
                var path = Emit(routines, dst);
                Wf.EmittedFile(routines, routines.RoutineCount, path);
            }
        }


        FS.FilePath Emit(in ApiHostRoutines src, ISemanticArchive dst)
        {
            var path = dst.SemanticPath(src.Uri);
            using var writer = path.Writer();
            Render(src, writer);
            return path;
        }

        [Op]
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

        [Op]
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


        [Op]
        string Format(MemoryAddress @base, Instruction src, byte i)
        {
            var kind = asm.kind(src, i);
            var desc = EmptyString;

            if(asm.isRegister(kind))
                desc = format(asm.register(src,i));
            else if(asm.isMem(kind))
                desc = format(asm.meminfo(src, i));
            else if (asm.isBranch(kind))
                desc = format(asm.branch(@base, src, i));
            else if(asm.isImm(kind))
                desc = Render(asm.imminfo(src, i));
            else
                desc = kind.ToString();

            return desc;
        }

        [Op]
        string Format(BinaryCode src)
            => src.Storage.FormatHexBytes(DataFormat);

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

        [Op]
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

        [Op]
        string DelimitInstruction(string location)
            => text.concat(location, ColSep, FxDelimiter);

        [Op]
        string LineLocation(Instruction src, MemoryAddress address, MemoryAddress offset, OffsetSequence seq)
            => text.concat(RenderAddress(src, AddressPad),
                Z0.Render.concat(text.spaced(offset)).PadRight(OffsetAddrPad),
                seq.Format(InstructionCountPad));

        [Op]
        string InstructionHeader(ApiInstruction src, MemoryAddress address, MemoryAddress offset,  OffsetSequence seq)
        {
            var left = LineLocation(src.Instruction, address, offset, seq);
            var right = text.concat(src.FormattedInstruction, LeftImply, src.InstructionCode, HeaderSep, Format(src.Encoded));
            return text.concat(left, ColSep, right);
        }

        [Op]
        static string format(MemoryAddress src)
            => string.Format("{0:x}" + HexFormatSpecs.PostSpec, src);

        [Op]
        static string format(AsmBranch src)
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

        [Op]
        static string format(IceRegister src)
            => text.format("{0}",src);

        [Op]
        static string Render(in ImmInfo src)
            => format(src);

        [Op]
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

        [Op]
        static string Render(OpKind src)
            => format(src);

        [Op]
        static string format(MemDirect src)
        {
            var dst = text.build();
            if(src.Base.IsSome())
                dst.Append(format(src.Base));
            else
                dst.Append("UNK");

            if(src.Scale.NonUnital && src.Scale.NonZero)
            {
                var scale = src.Scale.Format();
                dst.Append(text.concat(Chars.Star, scale));
            }

            if(src.Dx.NonZero)
                dst.Append(text.concat(Chars.Space, Chars.Plus, Chars.Space, Render(src.Dx)));

            return dst.ToString();
        }

        [Op]
        static string RenderSegKind(string symbol)
            => text.blank(symbol) ? EmptyString : text.concat("seg:", Chars.LBracket, symbol, Chars.RBracket);

        [Op]
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

        [Op]
        static string RenderAddress(Instruction src, int pad = 16)
            => Z0.Render.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        [Op]
        static string Render(MemorySize src)
            => asm.identify(src).Format();

        static StringBuilder Render(MemInfo src, StringBuilder builder)
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
                builder.Append(Render(src.Size));
            }
            return builder;
        }

        [Op]
        static string format(MemInfo src)
            => Render(src, text.build()).ToString();
    }
}