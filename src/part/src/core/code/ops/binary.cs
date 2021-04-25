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
        public static BinarySourceBlock binary(BinaryCode src, BinaryRenderKind render)
            => new BinarySourceBlock(src, render);

        [MethodImpl(Inline), Op]
        public static ApiBinaryBlock binary(ApiToken id, BinarySourceBlock src)
            => new ApiBinaryBlock(id,src);

        [MethodImpl(Inline), Op]
        public static ApiBinaryBlock binary(ApiToken id, BinaryCode src, BinaryRenderKind render)
            => binary(id,binary(src,render));
    }
}
