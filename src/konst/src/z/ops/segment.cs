//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;
    
    using static Konst;
    
    partial struct z
    {   
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> segment(string src)
            => vparts(N128.N, (ulong)pchar(src), size(src));         
    }
}