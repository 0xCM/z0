//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Joins the string representation of a sequence of items with no interspersed separator
        /// </summary>
        /// <param name="src">The values to be joined</param>
        [MethodImpl(Inline), Op]
        public static string concat(params object[] src)    
            => string.Concat(src);
    }
}