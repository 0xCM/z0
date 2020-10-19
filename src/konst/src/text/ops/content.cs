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

    partial class text
    {
        /// <summary>
        /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [MethodImpl(Options), Op]
        public static string content(string src, string left, string right)
        {
            (var i0, var i1) = indices(src, left, right);

            if(i0 != NotFound && i1 != NotFound &&(i0 < i1))
            {
                var start = i0 + left.Length;
                var length = i1 - start;
                return slice(src, start, length);
            }

            return EmptyString;
        }
    }
}