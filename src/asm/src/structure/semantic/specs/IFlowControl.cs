//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static FlowControl;
    using static FlowControlServices;

    public interface IFlowControl : IEntitled<FlowControl>
    {
        IFormatter<FlowControl> IEntitled<FlowControl>.ContentFormatter 
            => Formatters.content(FormatRender);

        ITitleFormatter<FlowControl> IEntitled<FlowControl>.TitleFormatter
            => Formatters.title(TitleRender);
    }

    readonly struct FlowControlServices : IFlowControl
    {
        internal static FormatRender<FlowControl> FormatRender 
            => src =>  src switch{
                Next => "next",
                UnconditionalBranch => "branch/unconditional",
                IndirectBranch => "branch/indirect",
                ConditionalBranch => "branch/conditional",
                Return => "return",
                FlowControl.Exception => "exception",		
                XbeginXabortXend => "XbeginXabortXend",
                Interrupt => "interrupt",
                IndirectCall => "call/indirect",
                Call => "call",
                _ => string.Empty
            };

        internal static TitleRender<FlowControl> TitleRender 
            => t => "flow";
    }
}