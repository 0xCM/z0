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
        public static AsmSourceBlock asm(Index<TextLine> src)
            => new AsmSourceBlock(src);

        [MethodImpl(Inline), Op]
        public static ApiAsmBlock asm(ApiToken id, AsmSourceBlock src)
            => new ApiAsmBlock(id,src);

        [MethodImpl(Inline), Op]
        public static ApiAsmBlock asm(ApiToken id, Index<TextLine> src)
            => asm(id,asm(src));
    }
}
