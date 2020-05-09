//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    public readonly partial struct SemanticRender
    { 
        public static SemanticRender Service => default(SemanticRender);

        public string Render(AsmBranchInfo src)
            => src.Render();
    
        const string Unknown = "???";

        const string PipeSep = " | ";

        public string Render(Register src)
            => src.ToString();


        const string Assign = CharText.Space + CharText.Colon + CharText.Eq + CharText.Space;

        public const string AspectDelimiter = CharText.Space + CharText.Pipe + CharText.Space;
    }
}