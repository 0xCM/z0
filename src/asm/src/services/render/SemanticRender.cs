//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    readonly partial struct SemanticRender : ISemanticRender
    { 
        public static SemanticRender Service => default(SemanticRender);

        public static string Render(AsmBranchInfo src)
            => src.Render();
    
        const string Unknown = "???";

        const string PipeSep = " | ";

        public static string Render(Register src)
            => src.ToString();

    }
}