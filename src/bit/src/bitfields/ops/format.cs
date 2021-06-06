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
        [Op]
        public static string format(BitfieldSeg src)
            => string.Format("{0}:[{1},{2}]", src.Name, src.Min, src.Max);

        [Op]
        public static string format(BitfieldSeg src, Span<char> buffer)
        {
            var offset = 0u;
            var count = render(src,ref offset, buffer);
            return new string(slice(buffer, 0u, count));
        }
    }
}