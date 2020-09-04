//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class FormatBits
    {
        public static string format<T>(T src, BitFormat config)
            where T : struct
                => format(z.bytes(in src), config);
    }
}