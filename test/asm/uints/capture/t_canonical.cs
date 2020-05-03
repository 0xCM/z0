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


    public class FormatCanonical
    {
        public IAsmContext Context {get;}
        
        readonly IAsmSemantic asm;

        string SectionSep {get;}

        string FunctionSep {get;}

        ushort InstructionCount;

        ushort FunctionSize;

        List<string> Descriptions;

        FolderPath CaptureRoot;

        Type HostType;

        int IdPad {get;}
            = 30;

        int InstructionCountPad {get;}
            = 3;

        int InstructionHeaderLength {get;}
            = 80;

        string OpCodeDelimiter {get;} 
            = "<==";       

        string HorizontalSep {get;}
            = " | ";

        public FormatCanonical(IAsmContext context, Type host, FolderPath root)
        {
            Context = context;
            asm = AsmSemantic.Service;
            CaptureRoot = root;
            HostType = host;

            var counter = 4;
            var size = 5;
            var counterPad = 1;

            var funlen = IdPad + InstructionHeaderLength + counter + size + counterPad + HorizontalSep.Length;

            SectionSep = new string(Chars.Dash,InstructionHeaderLength);  
            FunctionSep = new string(Chars.Dash,funlen);  
            Descriptions = list<string>();
        }

        string FormatCmp(Instruction src)
        {
            var details = asm.Details(src);
            var modified = details.RflagsWritten;
            return modified.ToString();
        }

        void Reset()
        {
            InstructionCount = 0;
            FunctionSize = 0;
            Descriptions.Clear();
        }

        public void Format()
        {
            var service = AsmWorkflows.Contextual(Context).HostCaptureService(CaptureRoot);
            var part = PartId.Canonical;
            var uri = ApiHostUri.Define(part, "microexpression");
            var capture = service.CaptureHost(uri,true);
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

            if(InstructionCount == 0)
            {
                Descriptions.Add(member.Id);
                Descriptions.Add(FunctionSep);
            }

            var id = text.concat(member.Reflected.Name, Chars.FSlash, member.KindId.Format()).PadRight(IdPad);
            var counted = InstructionCount.FormatCount(InstructionCountPad);
            var title = id + counted + FunctionSize.FormatSmallHex(true);
            var description = text.concat(src.FormattedInstruction, Chars.Space, OpCodeDelimiter, Chars.Space, src.InstructionCode);
            Descriptions.Add(text.concat(title, HorizontalSep, description));

            var operands = asm.Operands(src); 
            var summaries = new string[operands.Length];
            for(var i =0; i<operands.Length; i++)               
            {
                var a = operands[i];

                var kind = a.Kind; 

                var summary = kind.ToString().ToLower();
                if(kind == OpKind.Register)
                    summary += $"/{asm.Format(a.Register)}";
                else if(kind == OpKind.Memory)
                    summary += asm.Format(a.Memory);
                else if (a.Branch.IsNonEmpty)
                    summary += a.Branch.Format();
                else if(a.ImmInfo.IsNonEmpty)
                    summary += asm.Format(a.ImmInfo);
                else 
                    summary += "???";
                // switch(kind)
                // {
                //     case OpKind.Register:
                //         summary += $"/{asm.Format(a.Register)}";
                //     break;
                //     case OpKind.Memory:
                //         summary += asm.Format(a.Memory);
                //         break;
                // }
                summaries[i] = summary;                
            }
            
            Control.iteri(summaries, (i,s) => 
                Descriptions.Add(text.concat(title, HorizontalSep, $"Operand {i}: {s}")));


            if(src.Mnemonic == Mnemonic.Cmp)
            {
                Descriptions.Add(string.Concat(title, HorizontalSep, $"written: {FormatCmp(src)}"));
            }

            Descriptions.Add(text.concat(title, HorizontalSep, asm.FormatEntitled(src.FlowControl)));  
            Descriptions.Add(text.concat(title, HorizontalSep, SectionSep));  

            InstructionCount++;
            FunctionSize += (ushort)src.ByteLength;                                 
        }
    }


    public class t_canonical : t_asm<t_canonical>
    {

        public t_canonical()
        {

        }

        public void format_canonical()
        {

            var formatter = new FormatCanonical(Context, GetType(), DataDir);
            formatter.Format();
        }


    }
}