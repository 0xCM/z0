//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bytes(ReadOnlySpan<AsciCharCode> src)
            => Root.cast<AsciCharCode,byte>(src);        
    }
}