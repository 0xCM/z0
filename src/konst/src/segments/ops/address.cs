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
    using static z;
    
    partial struct SegRefs
    {
        [MethodImpl(Inline), Op]
        internal static MemoryAddress address(Vector128<ulong> src)
            => vcell(src,0);
    }
}