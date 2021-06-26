//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    partial struct Lines
    {
        [MethodImpl(Inline), Op]
        public static LineRange range(uint min, uint max, TextLine[] data)
            => new LineRange(min, max, data);
    }
}