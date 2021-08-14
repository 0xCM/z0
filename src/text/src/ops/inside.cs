//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    partial class text
    {
        [Op]
        public static string inside(string src, Interval<int> bounds)
        {
            var length = bounds.Right - bounds.Left;
            return slice(src, bounds.Right + 1, length - 1);
        }

        [Op]
        public static string inside(string src, Interval<uint> bounds)
        {
            var length = bounds.Right - bounds.Left;
            return slice(src, bounds.Right + 1, length - 1);
        }
    }
}