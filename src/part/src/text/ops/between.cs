//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using C = AsciCharCode;

    partial class text
    {
        /// <summary>
        /// Determines whether a specified <see cref='C'/> code is between a specified <see cref='C'/> minimum and <see cref='C'/> maximum
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Op]
        public static bool between(C src, C min, C max)
            => src >= min && src <= max;

        /// <summary>
        /// Determines whether a specified <see cref='char'/> is between a specified <see cref='char'/> minimum and <see cref='char'/> maximum
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The inclusive upper bound</param>
        [MethodImpl(Inline), Op]
        public static bool between(char src, char min, char max)
            => between((C)src, (C)min, (C)max);

        [Op]
        public static string between(string src, char left, char right)
        {
            var result = string.Empty;
            var i1 = src.IndexOf(left);
            if(i1 != -1)
            {
                var i2 = src.IndexOf(right, i1 + 1);
                if(i2 != -1)
                    result = substring(src,i1 + 1, i2 - i1 - 1);
            }
            return result;
        }
    }
}