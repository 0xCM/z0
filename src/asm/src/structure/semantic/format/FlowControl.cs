//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static FlowControl;
 
    partial struct AsmFormatServices 
    {
        public static string RenderContent(FlowControl src)
            => src switch{
                Next => "next",
                UnconditionalBranch => "uncoditional branch",
                IndirectBranch => "indirect branch",
                ConditionalBranch => "conditional branch",
                Return => "ret",
                FlowControl.Exception => "exception",		
                XbeginXabortXend => "XbeginXabortXend",
                Interrupt => "hardstop",
                IndirectCall => "indirect call",
                Call => "call",
                _ => "eh?"
            };
    }
}