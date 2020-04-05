//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    partial class XTend
    {
        /// <summary>
        /// Formats a 128-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string FormatList<T>(this Vector128<T> src, int pad = 0)
            where T : unmanaged
                => Vectors.span(src).FormatDataList(Chars.Comma,0,pad,true);
    }
}