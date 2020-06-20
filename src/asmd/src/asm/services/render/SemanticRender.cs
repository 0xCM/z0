//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public readonly partial struct SemanticRender
    { 
        public static SemanticRender Service => default(SemanticRender);

        public string Render(AsmBranchInfo src)
            => src.Render();
    
        const string Unknown = "???";

        public string Render(Register src)
            => src.ToString();
                
    }
}