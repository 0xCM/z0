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
        public static BitfieldSection section(StringAddress name, uint min, uint max, Index<BitfieldSeg> segments)
            => new BitfieldSection(name, min, max, segments);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitfieldSection untyped<T>(BitfieldSection<T> src)
            where T : unmanaged
                => new BitfieldSection(src.Name, bw32(src.FirstIndex), bw32(src.LastIndex), src.Segments);
    }
}