//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static MsilSourceBlock msil(Index<TextLine> src)
            => new MsilSourceBlock(src);

        [MethodImpl(Inline), Op]
        public static ApiMsilBlock msil(ApiToken id, MsilSourceBlock src)
            => new ApiMsilBlock(id,src);

        [MethodImpl(Inline), Op]
        public static ApiMsilBlock msil(ApiToken id, Index<TextLine> src)
            => msil(id,msil(src));
    }
}
