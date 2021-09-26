//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static string FormatHexBytes<T>(this T src)
            where T : unmanaged
                => HexFormatter.bytes(src);
    }
}