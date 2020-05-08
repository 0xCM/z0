//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IRenderSemantic
    {
        string[] Render(OpAddress located, Instruction[] src);
    }

    public readonly struct RenderSemantic : IRenderSemantic 
    {
        const byte OpKindPad  = 20;

        const byte SeqDigitPad = 2;

        const byte InstructionCountPad = 3;

        const byte AddressPad = 16;     

        public const byte SizePad = 5;   

        public const byte SubGridWidth = 80;

        public const byte OperandIndexPad = 6;

        public const byte Counter = 4;

        public const byte CounterPad = 1;

        public const byte ColSepWidth = 3;

        public const byte SectionWidth = AddressPad + SubGridWidth + Counter + SizePad + CounterPad + ColSepWidth;

        public static string SubGridSep 
            = new string(LineSepSymbol, SubGridWidth);
        
        public static string SectionSep 
            = new string(LineSepSymbol, SectionWidth);   

        public const char LineSepSymbol = Chars.Dash;

        const string LeftImply = "<==";

        const string ColSep = " | ";

        public static RenderSemantic Create() 
            => new RenderSemantic(new List<string>());
        
        readonly List<string> Descriptions;

        IAsmSemantic asm => AsmSemantic.Service;

        RenderSemantic(List<string> descriptions)
        {
            Descriptions = descriptions;
        }

        string Title(Instruction src, OffsetSeq offseq)
            => asm.RenderAddress(src, AddressPad) + offseq.Format(InstructionCountPad); 

        string Header(Instruction src, OffsetSeq offseq)
        {
            var title = Title(src, offseq);
            var description = text.concat(src.FormattedInstruction, Chars.Space, LeftImply, Chars.Space, src.InstructionCode);
            return text.concat(title, ColSep, description);
        }

        public string[] Render(OpAddress located, Instruction[] src)
        {
            Descriptions.Clear();
            
            var id = located.OpId;
            var @base = located.Address;
            Descriptions.Add(id);
            Descriptions.Add(SectionSep);
            
            var offseq = OffsetSeq.Zero;
            for(ushort i=0; i<src.Length; i++)
            {
                var inxs = src[i];
                Render(located, offseq, inxs);
                offseq = offseq.AccrueOffset((ushort)inxs.ByteLength);                
            }
            return Descriptions.ToArray();
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

        void Render(OpAddress located, OffsetSeq offseq, Instruction src)
        {
            var id = located.OpId;
            var @base = located.Address;
            var title = Title(src, offseq);
            var header = Header(src, offseq);
            Descriptions.Add(header);
                            
            var summaries = list<string>();
            for(var i =0; i<src.OpCount; i++)               
            {
                var kind = asm.OperandKind(src, i);

                var col01 = i.ToString().PadLeft(SeqDigitPad,'0').PadRight(OperandIndexPad);
                var col02 = asm.Render(kind).PadRight(OpKindPad);
                var col03 = text.concat(col01, ColSep, col02, Chars.Pipe, Chars.Space);
                var desc = RenderOperand(@base, src, i);
                
                summaries.Add(col03 + desc);       
            }

            foreach(var s in summaries)
                Descriptions.Add(text.concat(title, ColSep, $"{s}"));

            Descriptions.Add(text.concat(title, ColSep, SubGridSep));  
        }
    }
}