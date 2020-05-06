//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct SemanticRender
    {
        public static string Render(IAsmBranch src)
            => src.IsNonEmpty ? text.concat(src.IP - src.Base, RightArrow, src.Target) : string.Empty;
    }
}