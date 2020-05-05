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
        public IAsmContext Context {get;}
        
        readonly IAsmSemantic asm;

        readonly Type HostType;

        readonly FolderPath CaptureRoot;

        ushort InstructionCount;

        List<string> Descriptions;

        ushort FunctionSize;

        public SemanticFormatter(IAsmContext context, Type host, FolderPath root)
        {
            Context = context;
            asm = AsmSemantic.Service;
            CaptureRoot = root;
            Descriptions = list<string>();
            HostType = host;
            FunctionSize = 0;
        }

        void Reset()
        {
            InstructionCount = 0;
            FunctionSize = 0;
            Descriptions.Clear();
        }

        const string FlowTitle = "flow";

        public void Format(ApiHostUri host)        
        {
            var part = host.Owner;
            var service = AsmWorkflows.Create(Context).HostCaptureService(CaptureRoot);
            var capture = service.CaptureHost(host,true);
            var parsed = capture.Parsed;
            var decoder = Context.Decoder;
            var memberCount = parsed.Length;
            var archive = Archives.Services.Semantic;  

            archive.SemanticDir(HostType).Clear();                  

            for(ushort i=0; i<memberCount; i++)
            {
                var member = parsed[i];                
                var kind = member.KindId;

                decoder.Decode(member, ix => Describe(member, ix));                                    

                if(Descriptions.Count != 0)
                {
                    using var writer = archive.SemanticPath(HostType, part, member.Id).Writer();
                    Control.iter(Descriptions, writer.WriteLine); 
                }
                Reset();
            }
        }

        void Describe(ParsedMember member, Instruction src)
        {
            var @base = member.Address;
            insist((@base + FunctionSize) == src.IP);                           

            if(InstructionCount == 0)
            {
                Descriptions.Add(member.Id);
                Descriptions.Add(FunctionSep);
            }

            var id = text.concat(member.Method.Name, Chars.FSlash, member.KindId.Format(), Chars.Space, Chars.Space, src.IP.FormatHex(zpad:false)).PadRight(IdPad);
            var counted = InstructionCount.FormatCount(InstructionCountPad);
            var title = id + counted + FunctionSize.FormatSmallHex(true);
            var description = text.concat(src.FormattedInstruction, Chars.Space, OpCodeDelimiter, Chars.Space, src.InstructionCode);
            Descriptions.Add(text.concat(title, HorizontalSep, description));

            var operands = asm.Operands(@base, src); 
            var summaries = new string[operands.Length];
            for(var i =0; i<operands.Length; i++)               
            {
                var a = operands[i];

                var kind = a.Kind; 

                var index = i.ToString().PadLeft(OperandIndexPad,'0');
                var kindLabel = kind.ToString().ToLower().PadRight(InstructionKindPad);
                var summary = text.concat(index, Chars.Space, Chars.Pipe, Chars.Space, kindLabel, Chars.Pipe, Chars.Space);

                if(kind == OpKind.Register)
                    summary += asm.Format(a.Register);
                else if(kind == OpKind.Memory)
                    summary += asm.Format(a.Memory);
                else if (a.Branch.IsNonEmpty)
                    summary += asm.Format(a.Branch);
                else if(a.ImmInfo.IsNonEmpty)
                {
                    var immlabel = asm.ForamtKind(a.ImmInfo).PadRight(InstructionKindPad);
                    summary = text.concat(index, Chars.Space, Chars.Pipe, Chars.Space, immlabel, Chars.Pipe, Chars.Space);
                    summary += asm.Format(a.ImmInfo);
                }
                else 
                    summary += "???";
                summaries[i] = summary;                
            }
            
            Control.iter(summaries, s => 
                Descriptions.Add(text.concat(title, HorizontalSep, $"{s}")));


            Descriptions.Add(text.concat(title, HorizontalSep, FlowTitle.PadRight(SubTitlePad), Chars.Colon, Chars.Space, asm.Format(src.FlowControl)));  
            Descriptions.Add(text.concat(title, HorizontalSep, SectionSep));  

            InstructionCount++;
            FunctionSize += (ushort)src.ByteLength;      
        }
    }
}