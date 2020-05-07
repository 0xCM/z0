//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IAsmSemantic : ISemanticRender, ISemanticQuery
    {
        string Render(AsmInxsMemory src)
            => src.Render();
    }
    
    [ApiHost("semantic")]
    public readonly struct AsmSemantic : IAsmSemantic, IApiHost<AsmSemantic>
    {
        public static IAsmSemantic Service => default(AsmSemantic);
    }
}