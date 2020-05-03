//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static AsmFormatServices;

    public interface ISemanticFormat : 
        IFormatter<FlowControl>, 
        IFormatter<AsmOperandInfo>,
        IFormatter<Register>,
        IFormatter<AsmMemDirect>,
        IFormatter<AsmMemInfo>,
        IFormatter<AsmImmInfo>,
        IFormatter<AsmMemScale>,
        IFormatter<AsmMemDx>,
        IFormatter<MemorySize>,
        IFormatter<IAsmBranch>
    {
        string ForamtKind(AsmImmInfo src)
            => AsmFormatServices.FormatKind(src);
            
        string IFormatter<FlowControl>.Format(FlowControl src)
            => AsmFormatServices.RenderContent(src);

        string IFormatter<MemorySize>.Format(MemorySize src) 
            => AsmFormatServices.RenderContent(src);

        string IFormatter<AsmOperandInfo>.Format(AsmOperandInfo src)
            => AsmFormatServices.Format(src);            

        string IFormatter<Register>.Format(Register src)
            => AsmFormatServices.Format(src);            

        string IFormatter<AsmMemDirect>.Format(AsmMemDirect src)
            => AsmFormatServices.Format(src);            

        string IFormatter<AsmMemInfo>.Format(AsmMemInfo src)
            => AsmFormatServices.Format(src);            

        string IFormatter<AsmImmInfo>.Format(AsmImmInfo src)
            => AsmFormatServices.Format(src);            

        string IFormatter<AsmMemDx>.Format(AsmMemDx src)
            => AsmFormatServices.Format(src);            
        
        string IFormatter<AsmMemScale>.Format(AsmMemScale src)
            => AsmFormatServices.RenderContent(src);            

        string IFormatter<IAsmBranch>.Format(IAsmBranch src)
            => AsmFormatServices.Format(src);            
    }


    readonly partial struct AsmFormatServices : ISemanticFormat
    { 
        public static string Format(Register src)
            => src.ToString();
    }
}