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
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int startidx)
            => src.Substring(startidx);        

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline), Op]
        public static string slice(string src, int startidx, int length)
            => src.Substring(startidx, length);        
    }
}