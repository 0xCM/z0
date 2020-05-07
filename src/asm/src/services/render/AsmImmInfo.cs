//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial struct SemanticRender
    {
       public static string Render(AsmImmInfo src)
            => text.concat(src.Value.FormatHex(zpad:false, prespec:false));    
    }
}