//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct FormatSlots
    {
        [MethodImpl(Inline), Op]
        public static FormatSlot create(string src, uint start, uint end)
        {
            ClosedInterval<uint> range = (start,end);
            if(range.IsEmpty)
                return FormatSlot.Empty;
            else
                return new FormatSlot(src,range);
        }

        public int index(in FormatSlot src)
        {
            var inner = src.InnerText;
            (var m, var n) = (src.StartPos + 1, src.EndPos - 1);
            for(var i=m; i<n; i++)
            {

            }
            return default;
            //for(var i=; i<src.EndPos)
        }

    }
}