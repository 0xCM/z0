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

    public readonly struct SemanticRenderSvc : IDisposable
    {
        readonly HexFormatOptions DataFormat;

        readonly List<string> Buffer;

        public SemanticRenderSvc(List<string> descriptions)
        {
            Buffer = descriptions;
            DataFormat = HexFormatOptions.HexData;
        }

        public void Dispose()
        {

        }


        public static void run(in ApiPartRoutines src)
        {
            var part = src.Part;
            var dst = Archives.semantic();
            run(src,dst);
        }

        public static void run(in ApiPartRoutines src, ISemanticArchive dst)
        {
            var part = src.Part;
            var dir = dst.SemanticDir(part).Clear();
            var view = src.ViewHosts;
            var buffer = list<string>();
            var count = view.Length;
            var semantic = new SemanticRenderSvc(buffer);
            for(var i=0u; i<count; i++)
            {
                buffer.Clear();

                ref readonly var host = ref skip(view,i);
                var path = dst.SemanticPath(host.Uri);
                using var writer = path.Writer();
                semantic.Render(host, writer);
            }
        }


        public void Render(ApiHostRoutines src, StreamWriter dst)
        {
            var functions = span(src.Routines);
            var count = src.RoutineCount;

            for(var i=0; i<count; i++)
            {
                Render(skip(functions,i), dst);

                if(i != count - 1)
                    dst.WriteLine();
            }
        }

        public void Render(ApiRoutine src, StreamWriter dst)
        {
            Buffer.Clear();

            var id = src.OpId;
            Buffer.Add(id);
            Buffer.Add(SectionSep);

            var sequence = OffsetSequence.Zero;
            var address = src.OffsetAddress;

            for(var i=0; i<src.InstructionCount; i++)
            {
                var fx = src[i];
                Render(fx, address, sequence);

                var size = (uint)fx.ByteLength;
                address = address.AccrueOffset(size);
                sequence = sequence.AccrueOffset(size);
            }

            var rendered = Buffer.ToArray();
            for(var j=0; j<rendered.Length; j++)
                dst.WriteLine(rendered[j]);
        }

        public string FormatMemory(MemoryAddress @base, Instruction src, byte i)
            => Render(asm.meminfo(src, i));

        public string Format(MemoryAddress @base, Instruction src, byte i)
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

        public string Format(BinaryCode src)
            => text.concat("encoded", text.bracket(src.Length), Assign, src.Data.FormatHexBytes(DataFormat));

        public string Footer(ApiInstruction src)
        {
            if(asm.isCall(src.Instruction))
            {
                var bytes = Root.span(src.Encoded.Data);
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

        public void Render(ApiInstruction src, MemoryOffset address,  OffsetSequence sequence)
        {
            var id = src.OpId;
            var @base = src.Base;
            var fx = src.Instruction;
            var encoded = Format(src.Encoded);
            var location = LineLocation(fx, address, sequence);
            var header = InstructionHeader(src, address, sequence);
            Buffer.Add(header);

            var opcount = src.Instruction.OpCount;
            var summaries = Root.list<string>();
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

        [MethodImpl(Inline)]
        public string DelimitInstruction(string location)
            => text.concat(location, ColSep, FxDelimiter);

        public string LineLocation(Instruction src, MemoryOffset address, OffsetSequence sequence)
            => text.concat(RenderAddress(src, AddressPad),
                Z0.Render.concat(text.spaced(address.Offset.FormatAsmHex(6))).PadRight(OffsetAddrPad),
                sequence.Format(InstructionCountPad));

        public string InstructionHeader(ApiInstruction src, MemoryOffset address, OffsetSequence sequence)
        {
            var left = LineLocation(src.Instruction, address, sequence);
            var right = text.concat(src.FormattedInstruction, LeftImply, src.InstructionCode, HeaderSep, Format(src.Encoded));
            return text.concat(left, ColSep, right);
        }

        public static string Render(AsmBranchInfo src)
            => text.concat(src.Source.Format(), " + ",  src.TargetOffset.FormatMinimal(), " -> ",  (src.Source + src.TargetOffset).Format());

        static HexFormatOptions HexSpec
            => FormatOptions.hex(zpad:false, specifier:false);

        public static string format(in MemDx src)
            => (src.Size switch{
                MemDxSize.y1 => ((byte)src.Value).FormatHex(HexSpec),
                MemDxSize.y2 => ((ushort)src.Value).FormatHex(HexSpec),
                MemDxSize.y4 => ((uint)src.Value).FormatHex(HexSpec),
                _ => (src.Value).FormatHex(HexSpec),
            }) + "dx";

        [MethodImpl(Inline), Op]
        public static string format(in ImmInfo src)
            => Z0.Render.concat(src.Value.FormatHex(zpad:false, prespec:false));

        public static string Render(IceRegister src)
            => text.format("{0}",src);

        [MethodImpl(Inline), Op]
        public static string Render(in ImmInfo src)
            => format(src);

        public static string Render(MemDx src)
            => format(src);

        public static string format(OpKind src)
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

        public static string Render(OpKind src)
            => format(src);

        public static string Render(MemDirect src)
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

        static string RenderSegKind(string symbol)
            => text.blank(symbol) ? EmptyString : text.concat("seg:", Chars.LBracket, symbol, Chars.RBracket);

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

        public static string RenderAddress(Instruction src, int pad = 16)
            => Z0.Render.concat(src.IP.FormatHex(zpad:false, prespec:false)).PadRight(pad);

        public static string Render(MemorySize src)
            => asm.identify(src).Format();

        [Op]
        public static string Render(MemInfo src)
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

        [MethodImpl(Inline), Op]
        public static string Render(MemoryScale src)
        {
            if(src.IsNonEmpty)
                return src.Value.ToString();
            else
                return string.Empty;
        }
    }
}