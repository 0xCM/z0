//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public readonly struct RenderSemantic : IRenderSemantic 
    {     
        [MethodImpl(Inline)]
        public static RenderSemantic Create() 
            => new RenderSemantic(new List<string>());

        [MethodImpl(Inline)]
        public static RenderSemantic Create(List<string> buffer) 
            => new RenderSemantic(buffer);

        readonly HexFormatConfig DataFormat;

        readonly List<string> Buffer;

        const byte OpKindPad  = 20;

        const byte SeqDigitPad = 2;

        const byte InstructionCountPad = 3;

        const byte OffsetAddrPad = 12;

        const byte AddressPad = 16;     

        const byte SizePad = 5;   

        const byte InxsWidth = 80;

        public static string InsxDelimiter 
            = new string(Chars.Dash, InxsWidth);

        const byte Col0Pad = 10;

        const byte ColSepWidth = 3;

        const byte Counter = 4;

        const byte CounterPad = 1;

        const byte LocSepWidth = ColSepWidth;

        const byte SectionWidth = AddressPad + OffsetAddrPad + InxsWidth + Counter + SizePad + CounterPad + ColSepWidth;
        
        public static string SectionSep 
            = new string(Chars.Dash, SectionWidth);   

        const string LeftImply = " <== ";

        const string ColSep = " | ";

        const string HeaderSep = " || ";

        const string Assign = " = ";
        
        IAsmSemantic asm => AsmSemantic.Service;

        SemanticRender render => SemanticRender.Service;
        
        internal RenderSemantic(List<string> descriptions)
        {
            Buffer = descriptions;
            DataFormat = HexFormatConfig.HexData;
        }

        public void Render(HostInstructions src, StreamWriter dst)
        {
            var functions = src.Content;
            var count = src.MemberCount;            

            for(var i=0; i<count; i++)
            {
                RenderMember(functions[i],dst);                
                
                if(i != count - 1)
                    dst.WriteLine();                
            }    
        }

        void RenderMember(MemberInstructions src, StreamWriter dst)
        {
            Buffer.Clear();

            var id = src.OpId;

            Buffer.Add(id);
            Buffer.Add(SectionSep);

            var offseq = OffsetSeq.Zero;
            var offaddr = src.OffsetAddress;

            for(ushort i=0; i<src.TotalCount; i++)
            {
                var inxs = src[i];
                RenderInstruction(inxs, offaddr, offseq);

                var size = (ushort)inxs.ByteLength;
                offaddr = offaddr.AccrueOffset(size);
                offseq = offseq.AccrueOffset(size);
            }
            
            var rendered = Buffer.ToArray();
            for(var j=0; j<rendered.Length; j++)
                dst.WriteLine(rendered[j]);            
        }


        string RenderMemoryOperand(MemoryAddress @base, Instruction src, int i)
        {
            var subject = asm.MemInfo(src, i);
            var result = render.Render(subject);
            //var diagnostic = render.RenderAspects<IInstructionMemory>(subject);

            return result;
        }

        [MethodImpl(Inline)]
        static string Format(OpKind src)
            => src.ToString();

        string RenderOperand(MemoryAddress @base, Instruction src, int i)
        {            
            var kind = asm.OperandKind(src, i);
            var desc = Format(kind);

            if(asm.IsRegister(kind))
                desc = render.Render(asm.RegisterInfo(src,i));
            else if(asm.IsMem(kind))
                desc = RenderMemoryOperand(@base, src, i);
            else if (asm.IsBranch(kind))
                desc = render.Render(asm.BranchInfo(@base, src, i));
            else if(asm.IsImm(kind))
                desc = render.Render(asm.ImmInfo(src, i));                
            
            return desc;
        }

        string FormatBytes(byte[] src)
            => src.FormatHexBytes(DataFormat);

        string Format(BinaryCode src)
            => text.concat("encoded", text.bracket(src.Length), Assign, FormatBytes(src.Data));

        string FooterContent(LocatedInstruction src)
        {   
            if(asm.IsCall(src.Instruction))
            {
                var bytes = src.Encoded.Bytes;
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
        void RenderInstruction(LocatedInstruction src, MemoryOffset offaddr,  OffsetSeq offseq)
        {
            var id = src.OpId;
            var @base = src.BaseAddress;
            var inxs = src.Instruction;
            var encoded = Format(src.Encoded);
            var location = LineLocation(inxs, offaddr, offseq);
            var header = InstructionHeader(src, offaddr, offseq);
            Buffer.Add(header);

            
            var opcount = src.Instruction.OpCount;
            var summaries = Control.list<string>();
            for(var i =0; i<opcount; i++)               
            {
                var kind = asm.OperandKind(inxs, i);

                var col01 = i.ToString().PadLeft(SeqDigitPad,'0').PadRight(Col0Pad);
                var kindLabel = render.Render(kind).PadRight(OpKindPad);
                var col03 = text.concat(col01, ColSep, kindLabel, Chars.Pipe, Chars.Space);
                var desc = RenderOperand(@base, inxs, i);
                
                summaries.Add(col03 + desc);       
            }

            foreach(var s in summaries)
                Buffer.Add(text.concat(location, ColSep, $"{s}"));


             var fc = FooterContent(src);
             if(text.nonempty(fc))
             {   
                var footer = text.concat(location, ColSep, fc);
                Buffer.Add(footer);
             }

            Buffer.Add(DelimitInstruction(location));
        }

        [MethodImpl(Inline)]
        string DelimitInstruction(string location)
            => text.concat(location, ColSep, InsxDelimiter);

        string LineLocation(Instruction src, MemoryOffset offaddr, OffsetSeq offseq)
            => text.concat(
                render.RenderAddress(src, AddressPad), 
                text.concat(
                    text.spaced(offaddr.Offset.FormatAsmHex(6))
                    ).PadRight(OffsetAddrPad),
                offseq.Format(InstructionCountPad)
                ); 

        string InstructionHeader(LocatedInstruction src, MemoryOffset offaddr, OffsetSeq offseq)
        {
            var left = LineLocation(src.Instruction, offaddr, offseq);
            var right = text.concat(src.FormattedInstruction, LeftImply, src.InstructionCode, HeaderSep, Format(src.Encoded));
            return text.concat(left, ColSep, right);
        }
    }
}