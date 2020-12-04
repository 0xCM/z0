//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ClrQuery
    {
        [Op]
        public static string format(in MethodMetadata src)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
        }
    }
}