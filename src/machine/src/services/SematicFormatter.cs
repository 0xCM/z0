//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    using static Seed;
    using static Memories;

    using static FormatConstants;

    public class SemanticFormatter : ISemanticFormatter
    {
        public static ISemanticFormatter Create(IMachineContext context)
            => new SemanticFormatter(context, context.TargetRoot);

        public IMachineContext Context {get;}
        
        readonly IAsmSemantic Semantic;

        readonly FolderPath CaptureRoot;

        readonly FolderName TargetFolder;

        ushort InstructionCount;

        List<string> Descriptions;

        ushort FunctionSize;

        public SemanticFormatter(IMachineContext context, FolderPath root)
        {
            Context = context;
            Semantic = AsmSemantic.Service;
            CaptureRoot = root;
            Descriptions = list<string>();
            FunctionSize = 0;
            TargetFolder = FolderName.Define(ExecutingApp);
        }

        void Reset()
        {
            InstructionCount = 0;
            FunctionSize = 0;
            Descriptions.Clear();
        }

        const string FlowTitle = "flow";

        public void Render(PartInstructions src)        
        {
            var part = src.Part;
            var inxs = src.Instructions;
            var archive = Archives.Services.Semantic;
            var dir = archive.SemanticDir(part).Clear();

            for(var i = 0; i < src.Instructions.Length; i++)
                Render(src.Instructions[i]);
        }

        public void Render(HostInstructions src)        
        {
            var host = src.Host;
            var part = host.Owner;
            var inxs = src.Instructions;
            var archive = Archives.Services.Semantic;
            var path = archive.SemanticPath(host);  
            var opcount = src.OpCount;

            using var writer = path.Writer();

            for(var i=0; i<opcount; i++)
            {
                Render(inxs[i]);
                Emit(writer);
                
                if(i != opcount - 1)
                    writer.WriteLine();
                
                Reset();
            }
        }

        void Emit(StreamWriter dst)
        { 
            if(Descriptions.Count != 0)
                Control.iter(Descriptions, dst.WriteLine);                         
        }

        void Render(OpInstructions src)
        {
            for(var i=0; i<src.Instructions.Length; i++)
                Render(src[i]);
        }
        
        string Title(Instruction src)
        {
            var location = Semantic.RenderAddress(src, AddressPad);
            var counted = InstructionCount.FormatCount(InstructionCountPad);
            var title = location + counted + FunctionSize.FormatSmallHex(true);
            return title;
        }

        string Title(OpInstruction src)
            => Title(src.Instruction);

        string Header(Instruction src)
        {
            var title = Title(src);
            var description = text.concat(src.FormattedInstruction, Chars.Space, LeftImply, Chars.Space, src.InstructionCode);
            return text.concat(title, ColSep, description);
        }

        string Header(OpInstruction src)
            => Header(src.Instruction);

        void Render(OpInstruction src)
        {
            var idOp = src.OpId;
            var inxs = src.Instruction;
            var @base = src.BaseAddress;
            insist((@base + FunctionSize) == inxs.IP);      

            if(InstructionCount == 0)
            {
                Descriptions.Add(idOp);
                Descriptions.Add(SectionSep);
            }

            var title = Title(src);
            var header = Header(src);
            Descriptions.Add(header);

            var operands = Semantic.Operands(@base, inxs); 
            var summaries = new string[operands.Length];
            for(var i =0; i<operands.Length; i++)               
            {
                var a = operands[i];

                var kind = a.Kind; 

                var col01 = i.ToString().PadLeft(OperandIndexDigits,'0').PadRight(OperandIndexPad);
                var col02 = Semantic.Render(kind).PadRight(InstructionKindPad);
                var col03 = text.concat(col01, ColSep, col02, Chars.Pipe, Chars.Space);

                if(kind == OpKind.Register)
                    col03 += Semantic.Render(a.Register);
                else if(kind == OpKind.Memory)
                    col03 += Semantic.Format(a.Memory);
                else if (a.Branch.IsNonEmpty)
                    col03 += Semantic.Format(a.Branch);
                else if(a.ImmInfo.IsNonEmpty)
                {
                    var immlabel = Semantic.RenderKind(a.ImmInfo).PadRight(InstructionKindPad);
                    col03 = text.concat(col01, ColSep, immlabel, Chars.Pipe, Chars.Space);
                    col03 += Semantic.Format(a.ImmInfo);
                }
                else 
                    col03 += "???";
                summaries[i] = col03;                
            }

            Control.iter(summaries, s =>  Descriptions.Add(text.concat(title, ColSep, $"{s}")));

            Descriptions.Add(text.concat(title, ColSep, FlowTitle.PadRight(OperandIndexPad), ColSep, Semantic.Format(inxs.FlowControl)));  
            Descriptions.Add(text.concat(title, ColSep, SubGridSep));  

            InstructionCount++;
            FunctionSize += (ushort)inxs.ByteLength;

        }

    }
}