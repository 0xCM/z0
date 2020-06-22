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

    using static Konst;
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

        void DescribeResources()
        {
            void DescribeResource(BinaryResource resource)
            {
                Trace(nameof(resource.Identifier), 
                    text.concat(
                        resource.Identifier.PadRight(15), 
                        Chars.Pipe, Chars.Space,
                        resource.Data.FormatHex())
                    );                
            }

            Root.iter(TestCases, DescribeResource);         
        }

        void check_cases()
        {

            
        }

    }
}