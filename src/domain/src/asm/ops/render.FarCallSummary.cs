//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Konst;
    
    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static string render(in FarCallSummary src)
            => counts(src).Format();
    }
}