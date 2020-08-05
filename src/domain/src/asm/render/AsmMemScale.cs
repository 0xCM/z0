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
        public string Render(MemScale src)
        {
            if(src.IsNonEmpty)
                return src.Value.ToString();
            else
                return string.Empty;
        }
    }
}