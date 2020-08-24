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
    using static AsmRenderPatterns;

    public readonly struct RenderSemantic
    {
        [MethodImpl(Inline)]
        public static RenderSemantic Create()
            => new RenderSemantic(new List<string>());

        readonly HexFormatConfig DataFormat;

        readonly List<string> Buffer;

        SemanticRender render
            => SemanticRender.Service;

        public RenderSemantic(List<string> descriptions)
        {
            Buffer = descriptions;
            DataFormat = HexFormatConfig.HexData;
        }

        public void Render(HostAsmFx src, StreamWriter dst)
        {
            var functions = src.Data;
            var count = src.MemberCount;

            for(var i=0; i<count; i++)
            {
                Render(functions[i],dst);

                if(i != count - 1)
                    dst.WriteLine();
            }
        }

        void Render(MemberAsmFx src, StreamWriter dst)
        {
            Buffer.Clear();

            var id = src.OpId;
            Buffer.Add(id);
            Buffer.Add(SectionSep);

            var sequence = OffsetSequence.Zero;
            var address = src.OffsetAddress;

            for(var i=0; i<src.TotalCount; i++)
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

        string FormatMemory(MemoryAddress @base, Instruction src, int i)
            => render.Render(asm.memInfo(src, i));

        string Format(MemoryAddress @base, Instruction src, byte i)
        {
            var kind = asm.kind(src, i);
            var desc = kind.ToString();

            if(asm.isRegister(kind))
                desc = render.Render(asm.register(src,i));
            else if(asm.isMem(kind))
                desc = FormatMemory(@base, src, i);
            else if (asm.isBranch(kind))
                desc = render.Render(asm.branch(@base, src, i));
            else if(asm.isImm(kind))
                desc = render.Render(asm.immInfo(src, i));

            return desc;
        }

        string Format(BinaryCode src)
            => text.concat("encoded", text.bracket(src.Length), Assign, src.Data.FormatHexBytes(DataFormat));

        string Footer(BasedAsmFx src)
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

        void Render(BasedAsmFx src, MemoryOffset address,  OffsetSequence sequence)
        {
            var id = src.OpId;
            var @base = src.BaseAddress;
            var fx = src.Instruction;
            var encoded = Format(src.Encoded);
            var location = LineLocation(fx, address, sequence);
            var header = InstructionHeader(src, address, sequence);
            Buffer.Add(header);

            var opcount = src.Instruction.OpCount;
            var summaries = Root.list<string>();
            for(var i =0; i<opcount; i++)
            {
                var kind = asm.kind(fx, i);
                var col01 = i.ToString().PadLeft(SeqDigitPad,'0').PadRight(Col0Pad);
                var kindLabel = render.Render(kind).PadRight(OpKindPad);
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
        string DelimitInstruction(string location)
            => text.concat(location, ColSep, FxDelimiter);

        string LineLocation(Instruction src, MemoryOffset address, OffsetSequence sequence)
            => text.concat(render.RenderAddress(src, AddressPad),
                text.concat(text.spaced(address.Offset.FormatAsmHex(6))).PadRight(OffsetAddrPad),
                sequence.Format(InstructionCountPad));

        string InstructionHeader(BasedAsmFx src, MemoryOffset address, OffsetSequence sequence)
        {
            var left = LineLocation(src.Instruction, address, sequence);
            var right = text.concat(src.FormattedInstruction, LeftImply, src.InstructionCode, HeaderSep, Format(src.Encoded));
            return text.concat(left, ColSep, right);
        }
    }
}