//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    partial class FormatBits
    {
        public static string format<T>(T src, BitFormatConfig config)
            where T : struct
                => format(BitConvert.GetBytes(in src), config);

    }
}