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
        public static SymbolSpec<AsciCharCode,byte,W8> symbols(params AsciCharCode[] src)
            => AsciG.symbol<AsciCharCode,byte,W8>(src);
    }
}