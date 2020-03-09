//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    partial class TextExtensions
    {
        public static string Between(this string src, char left, char right)
        {
            var result = string.Empty;
            var i1 = src.IndexOf(left);
            if(i1 != -1)
            {
                var i2 = src.IndexOf(right, i1 + 1);
                if(i2 != -1)
                    result = src.Substring(i1 + 1, i2 - i1 - 1);
            }
            return result;
        }
    }
}