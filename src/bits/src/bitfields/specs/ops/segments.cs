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
        public static BitfieldSeg<K>[] segments<K>(params BitfieldSeg<K>[] src)
            where K : unmanaged
                => src;
    }
}