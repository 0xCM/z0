//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Konst;
    
    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static string render(in ImmInfo src)
            => AsmRender.render(src);
    }
}