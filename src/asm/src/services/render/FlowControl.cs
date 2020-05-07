//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static FlowControl;
 
    partial struct SemanticRender 
    {
        public static string Render(FlowControl src)
            => src switch{
                Next => "next",
                UnconditionalBranch => "branch[unconditional]",
                IndirectBranch => "branch[indirect]",
                ConditionalBranch => "branch[conditional]",
                Return => "ret",
                Call => "call",
                IndirectCall => "call[indirect]",
                FlowControl.Exception => "exception",		
                XbeginXabortXend => "XbeginXabortXend",
                Interrupt => "hardstop",
                _ => Unknown
            };
    }
}