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

    using static Seed;
    using static Memories;

    public interface IRenderSemantic
    {
        
    }

    public readonly struct RenderSemantic : IRenderSemantic 
    {
        const byte OpKindPad  = 20;

        const byte SeqDigitPad = 2;

        const byte InstructionCountPad = 3;

        const byte OffsetAddrPad = 12;

        const byte AddressPad = 16;     

        public const byte SizePad = 5;   

        public const byte SubGridWidth = 80;

        public const byte OperandIndexPad = 6;

        public const byte Counter = 4;

        public const byte CounterPad = 1;

        public const byte ColSepWidth = 3;

        public const byte SectionWidth = AddressPad +  OffsetAddrPad + SubGridWidth + Counter + SizePad + CounterPad + ColSepWidth;

        public static string SubGridSep 
            = new string(LineSepSymbol, SubGridWidth);
        
        public static string SectionSep 
            = new string(LineSepSymbol, SectionWidth);   

        public const char LineSepSymbol = Chars.Dash;

        const string LeftImply = " <== ";

        const string ColSep = " | ";

        public static RenderSemantic Create() 
            => new RenderSemantic(new List<string>());
        
        readonly List<string> Descriptions;

        IAsmSemantic asm => AsmSemantic.Service;

        RenderSemantic(List<string> descriptions)
        {
            Descriptions = descriptions;
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
            Descriptions.Clear();

            var id = src.OpId;
            var @base = src.BaseAddress;

            Descriptions.Add(id);
            Descriptions.Add(SectionSep);

            var offseq = OffsetSeq.Zero;
            var offaddr = src.OffsetAddress;

            for(ushort i=0; i<src.TotalCount; i++)
            {
                var inxs = src[i];
                Render(inxs, offaddr, offseq);

                var size = (ushort)inxs.ByteLength;
                offaddr = offaddr.AccrueOffset(size);
                offseq = offseq.AccrueOffset(size);
            }
            
            var rendered = Descriptions.ToArray();
            for(var j=0; j<rendered.Length; j++)
                dst.WriteLine(rendered[j]);            
        }


        string RenderOperand(MemoryAddress @base, Instruction src, int i)
        {            
            var kind = asm.OperandKind(src, i);
            var desc = $"???:{kind}";

            if(asm.IsRegister(kind))
                desc = asm.Render(asm.RegisterInfo(src,i));
            else if(asm.IsMem(kind))
                desc = asm.Format(asm.MemInfo(src, i));
            else if (asm.IsBranch(kind))
                desc = asm.Render(asm.BranchInfo(@base, src, i));
            else if(asm.IsImm(kind))
                desc = asm.Render(asm.ImmInfo(src, i));                
            
            return desc;
        }

        void Render(LocatedInstruction src, MemoryOffset offaddr,  OffsetSeq offseq)
        {
            var id = src.OpId;
            var @base = src.BaseAddress;
            var inxs = src.Instruction;
            var title = Title(inxs, offaddr, offseq);
            var header = Header(inxs, offaddr, offseq);
            Descriptions.Add(header);
                            
            var opcount = src.Instruction.OpCount;
            var summaries = list<string>();
            for(var i =0; i<opcount; i++)               
            {
                var kind = asm.OperandKind(inxs, i);

                var col01 = i.ToString().PadLeft(SeqDigitPad,'0').PadRight(OperandIndexPad);
                var col02 = asm.Render(kind).PadRight(OpKindPad);
                var col03 = text.concat(col01, ColSep, col02, Chars.Pipe, Chars.Space);
                var desc = RenderOperand(@base, inxs, i);
                
                summaries.Add(col03 + desc);       
            }

            foreach(var s in summaries)
                Descriptions.Add(text.concat(title, ColSep, $"{s}"));

            Descriptions.Add(text.concat(title, ColSep, SubGridSep));  
        }

        [MethodImpl(Inline)]
        static ulong JmpDelta(ulong src, ulong dst, byte inxsSize)
            => dst - (src + inxsSize);

        string Title(Instruction src, MemoryOffset offaddr, OffsetSeq offseq)
            => text.concat(
                asm.RenderAddress(src, AddressPad), 
                text.concat(
                    text.spaced(offaddr.Offset.FormatAsmHex(6))
                    ).PadRight(OffsetAddrPad),
                offseq.Format(InstructionCountPad)
                ); 

        string Header(Instruction src, MemoryOffset offaddr, OffsetSeq offseq)
        {
            var title = Title(src, offaddr, offseq);
            var description = text.concat(src.FormattedInstruction, LeftImply, src.InstructionCode);
            return text.concat(title, ColSep, description);
        }
    }
}