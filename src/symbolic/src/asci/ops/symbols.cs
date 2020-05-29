//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;

    partial class AsciCodes     
    {        
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Symbol<AsciChar,byte>> symbols(AsciCode16 src)
            => cast<Symbol<AsciChar,byte>>(bytes(vinflate(src.Data)));
    }
}