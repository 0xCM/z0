//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static SemanticRender;

    public interface IRender<T>
    {
        string Render(T src);
    }

    public interface ISemanticRender : 
        IRender<FlowControl>,        
        IRender<Register>,

        IRender<MemDx>,
        IRender<MemInfo>,
        IRender<MemDirect>,
        IRender<MemScale>,
        IRender<MemorySize>,

        IRender<OpKind>,
        IRender<ImmInfo>,
        IRender<AsmBranchInfo>
    {

        string RenderAspects<T>(object src)
            where T : class
                => Service.RenderAspects<T>(src);
    }
}