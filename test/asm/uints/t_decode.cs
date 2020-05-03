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

    public class t_decode : t_asm<t_decode>
    {
        IAsmFunctionCases TestCases {get;}
        
        IAsmSemantic asm {get;}

        string SectionSep {get;}

        public t_decode()
        {
            TestCases = ParsedFunctions.Service;
            asm = AsmSemantic.Service;
            SectionSep = new string(Chars.Dash,80);
        }

        string FormatCmp(Instruction src)
        {
            var details = asm.Details(src);

            var modified = details.RflagsWritten;
            return modified.ToString();
        }

    

        // void check_decode(OpKindId id, params NumericKind[] kinds)
        // {               
        //     var count = z8;
        //     var size = z16;
        //     var label = LocalAddress.Empty;
        //     const string MapsTo = "==>";


        //     void OnDecoded(Instruction src)
        //     {
        //         var counted = count.FormatCount(2);                
        //         var title = id.Format() + counted + label;
        //         var description = text.concat(src.InstructionCode, Chars.Space, MapsTo, Chars.Space, src.FormattedInstruction);
        //         Trace(title, description);

        //         var operands = asm.Operands(src); 
        //         var summaries = new string[operands.Length];
        //         for(var i =0; i<operands.Length; i++)               
        //         {
        //             var a = operands[i];

        //             var kind = a.Kind; 

        //             var summary = kind.ToString().ToLower();
        //             switch(kind)
        //             {
        //                 case OpKind.Register:
        //                     summary += $"/{a.Register.Format()}";
        //                     break;
        //             }
        //             summaries[i] = summary;                
        //         }
                
        //         Control.iteri(summaries, (i,s) => Trace(title, $"Operand {i}: {s}"));


        //         if(src.Mnemonic == Mnemonic.Cmp)
        //         {
        //             Trace(title, $"written: {FormatCmp(src)}");
        //         }


        //         Trace(title, asm.FormatEntitled(src.FlowControl));  
        //         Trace(title, SectionSep);           

        //         count++;
        //         label += src.ByteLength;
        //         size += (ushort)src.ByteLength;
        //     }

        //     AsmCheck.Decoder.Decode(TestCases.Case(id,kinds), OnDecoded);
        // }


        void DescribeResources()
        {
            void DescribeResource(BinaryResource resource)
            {
                Trace(nameof(resource.Id), 
                    text.concat(
                        resource.Id.PadRight(15), 
                        Chars.Pipe, Chars.Space,
                        resource.Data.FormatHex())
                    );                
            }

            Control.iter(TestCases, DescribeResource);         
        }

        void check_cases()
        {

            //check_decode(OpKindId.Or, NumericKind.U8, NumericKind.U8);
            //check_decode(OpKindId.Within, NumericKind.U8, NumericKind.U8, NumericKind.U8);
        }

    }
}