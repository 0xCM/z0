//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static SymbolSpec<AsciCharCode,byte,W8> spec(params AsciCharCode[] src)
            => spec<AsciCharCode,byte,W8>(src);
    }
}