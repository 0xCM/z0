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
        public string Render(FlowControl src)
            => src switch{
                Next => "next",
                UnconditionalBranch => "branch[absolute]",
                IndirectBranch => "branch[indirect]",
                ConditionalBranch => "branch[test]",
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