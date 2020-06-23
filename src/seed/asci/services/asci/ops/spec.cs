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
        public static SymbolSpec<AsciCharCode,N1> spec(params AsciCharCode[] src)
            => spec<AsciCharCode,byte, N1>(src);
    }
}