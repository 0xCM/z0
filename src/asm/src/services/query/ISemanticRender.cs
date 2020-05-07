//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static SemanticRender;

    public interface IRender
    {
        string Render();
    }

    public interface IRender<T>
    {
        string Render(T src);
    }

    public interface ISemanticRender : 
        IRender<FlowControl>,        
        IRender<Register>,
        IRender<AsmMemDx>,
        IRender<AsmMemScale>,
        IRender<MemorySize>,
        IRender<OpKind>,
        IRender<AsmImmInfo>,
        IRender<AsmBranchInfo>,

        IFormatter<FlowControl>, 
        IFormatter<Register>,
        IFormatter<AsmMemDirect>,
        IFormatter<AsmMemInfo>,
        IFormatter<AsmMemScale>,
        IFormatter<AsmMemDx>,
        IFormatter<MemorySize>,
        IFormatter<OpKind>
    {

        string RenderAspects<T>(object src)
            => Service.RenderAspects<T>(src);

        string IRender<FlowControl>.Render(FlowControl src)
            => SemanticRender.Render(src);

        string IRender<Register>.Render(Register src)
            => SemanticRender.Render(src);

        string IRender<AsmMemDx>.Render(AsmMemDx src)
            => SemanticRender.Render(src);

        string IRender<AsmMemScale>.Render(AsmMemScale src)
            => SemanticRender.Render(src);

        string IRender<MemorySize>.Render(MemorySize src)
            => SemanticRender.Render(src);

        string IRender<OpKind>.Render(OpKind src)
            => SemanticRender.Render(src);

        string IRender<AsmImmInfo>.Render(AsmImmInfo src)
            => SemanticRender.Render(src);            

        string IRender<AsmBranchInfo>.Render(AsmBranchInfo src)
            => SemanticRender.Render(src);            

        string IFormatter<AsmMemDx>.Format(AsmMemDx src)
            => SemanticRender.Render(src);            

        string RenderAddress(Instruction src, int pad = 16)
            => SemanticRender.RenderAddress(src, pad);
            
        string IFormatter<FlowControl>.Format(FlowControl src)
            => SemanticRender.Render(src);

        string IFormatter<MemorySize>.Format(MemorySize src) 
            => SemanticRender.Render(src);

        string IFormatter<Register>.Format(Register src)
            => SemanticRender.Render(src);            

        string IFormatter<AsmMemDirect>.Format(AsmMemDirect src)
            => SemanticRender.Render(src);            

        string IFormatter<AsmMemInfo>.Format(AsmMemInfo src)
            => SemanticRender.Render(src);            

        string IFormatter<AsmMemScale>.Format(AsmMemScale src)
            => SemanticRender.Render(src);            


        string IFormatter<OpKind>.Format(OpKind src)
            => SemanticRender.Render(src);            
    }
}