//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Part;

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op]
        public static BitfieldSectionSpec section(StringAddress name, uint min, uint max, Index<BitfieldSegSpec> segments)
            => new BitfieldSectionSpec(name, min, max, segments);
    }
}