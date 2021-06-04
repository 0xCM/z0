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

    partial struct BitRender
    {
        [Op]
        public static uint render(N32 n, N8 w, uint src, uint offset, Span<char> dst)
        {
            var counter = 0u;
            var x = z8;

            var cells = bytes(src);
            x = skip(cells,0);
            counter += render(w, x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,1);
            counter += render(w, x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,2);
            counter += render(w, x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,3);
            counter += render(w, x, counter + offset, dst);

            return counter;
        }
    }
}