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
        public static BitfieldSeg segment(StringAddress name, byte min, byte max)
            => new BitfieldSeg(name, min, max);
    }
}