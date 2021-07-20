//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op]
        public static BitfieldSeg segment(Identifier name, uint min, uint max)
            => new BitfieldSeg(name, min, max);

        [MethodImpl(Inline), Op]
        public static BitfieldSeg<K> segment<K>(K segid, uint min, uint max)
            where K : unmanaged
                => new BitfieldSeg<K>(segid, min, max);
    }
}