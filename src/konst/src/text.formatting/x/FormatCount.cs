//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    partial class XTend
    {
        public static string FormatCount(this byte src, int zpad = 3)
            => src.ToString().PadLeft(zpad, '0').PadLeft(zpad + 1, Chars.Space) + Chars.Space;

        public static string FormatCount(this ushort src, int zpad = 5)
            => src.ToString().PadLeft(zpad, '0').PadLeft(zpad + 1, Chars.Space) + Chars.Space;
    }
}