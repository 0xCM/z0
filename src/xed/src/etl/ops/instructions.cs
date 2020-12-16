//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct XedWfOps
    {
        [Op]
        public static Index<XedInstructionRow> instructions(XedPattern[] src)
        {
            var input = @readonly(src);
            var count = input.Length;
            var dst = alloc<XedInstructionRow>(count);
            map(src,dst);
            return dst;
        }
    }
}