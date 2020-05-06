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
        const string RightArrow = " -> ";

        const string LeftArrow = " <- ";

        const string Unknown = "???";

        public static string Render(Register src)
            => src.ToString();
    }
}