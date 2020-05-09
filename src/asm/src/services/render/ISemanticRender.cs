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
        IRender<AsmMemInfo>,
        IRender<AsmMemDirect>,
        IRender<AsmMemScale>,
        IRender<MemorySize>,

        IRender<OpKind>,
        IRender<AsmImmInfo>,
        IRender<AsmBranchInfo>
    {

        string RenderAspects<T>(object src)
            where T : class
                => Service.RenderAspects<T>(src);

    }
}