//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op]
        public static BitfieldSeg segment(Identifier name, uint pos, uint offset, uint width)
            => new BitfieldSeg(name, pos, offset, width);

        [MethodImpl(Inline), Op]
        public static BitfieldSeg<K> segment<K>(uint pos, K segid, uint offset, uint width)
            where K : unmanaged
                => new BitfieldSeg<K>(segid, pos, offset, width);
    }
}