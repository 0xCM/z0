//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public static partial class XAsci
    {
        [MethodImpl(Inline)]
        public static int FirstIndexOf<T>(this T src, AsciChar match)
            where T : IAsciSeq
                => AsciG.index(src, match);
    }
}
