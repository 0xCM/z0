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

    using static Seed;
    using static Memories;

    using static FormatConstants;

    public class SemanticFormatter : ISemanticFormatter
    {
        public static ISemanticFormatter Create(IMachineContext context)
            => new SemanticFormatter(context, context.TargetRoot);

        public IMachineContext Context {get;}
        
        readonly IAsmSemantic asm;

        readonly FolderPath CaptureRoot;

        readonly FolderName TargetFolder;

        ushort InstructionCount;

        List<string> Descriptions;

        ushort FunctionSize;

        public SemanticFormatter(IMachineContext context, FolderPath root)
        {
            Context = context;
            asm = AsmSemantic.Service;
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

        public void Format(HostCodeInstructions hcInxs)        
        {
            var host = hcInxs.Host;
            var part = host.Owner;

            var archive = Archives.Services.Semantic;  
            archive.SemanticDir(host).Clear();                  

            for(var i=0; i<hcInxs.CodeInstructions.Length; i++)
            {
                var funcInxs = hcInxs.CodeInstructions[i];
                var id = funcInxs.OpId;
                Format(funcInxs);

                if(Descriptions.Count != 0)
                {
                    using var writer = archive.SemanticPath(host, id).Writer();
                    Control.iter(Descriptions, writer.WriteLine); 
                }

                Reset();
            }
        }

        void Format(UriCodeInstructions funcInxs)
        {
            for(var i=0; i<funcInxs.Instructions.Length; i++)
            {
                var inxs = funcInxs[i];
                Describe(inxs);
            }

        }
        
        void Describe(UriCodeInstruction src)
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

            var location = asm.RenderAddress(inxs,AddressPad);
            var counted = InstructionCount.FormatCount(InstructionCountPad);
            var title = location + counted + FunctionSize.FormatSmallHex(true);
            var description = text.concat(inxs.FormattedInstruction, Chars.Space, LeftImply, Chars.Space, inxs.InstructionCode);
            Descriptions.Add(text.concat(title, ColSep, description));

            var operands = asm.Operands(@base, inxs); 
            var summaries = new string[operands.Length];
            for(var i =0; i<operands.Length; i++)               
            {
                var a = operands[i];

                var kind = a.Kind; 

                var col01 = i.ToString().PadLeft(OperandIndexDigits,'0').PadRight(OperandIndexPad);
                var col02 = asm.Render(kind).PadRight(InstructionKindPad);
                var col03 = text.concat(col01, ColSep, col02, Chars.Pipe, Chars.Space);

                if(kind == OpKind.Register)
                    col03 += asm.Render(a.Register);
                else if(kind == OpKind.Memory)
                    col03 += asm.Format(a.Memory);
                else if (a.Branch.IsNonEmpty)
                    col03 += asm.Format(a.Branch);
                else if(a.ImmInfo.IsNonEmpty)
                {
                    var immlabel = asm.RenderKind(a.ImmInfo).PadRight(InstructionKindPad);
                    col03 = text.concat(col01, ColSep, immlabel, Chars.Pipe, Chars.Space);
                    col03 += asm.Format(a.ImmInfo);
                }
                else 
                    col03 += "???";
                summaries[i] = col03;                
            }

            Control.iter(summaries, s => 
                Descriptions.Add(text.concat(title, ColSep, $"{s}")));


            Descriptions.Add(text.concat(title, ColSep, FlowTitle.PadRight(OperandIndexPad), ColSep, asm.Format(inxs.FlowControl)));  
            Descriptions.Add(text.concat(title, ColSep, SubGridSep));  

            InstructionCount++;
            FunctionSize += (ushort)inxs.ByteLength;

        }

    }
}