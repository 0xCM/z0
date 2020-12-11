//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Render
    {
        /// <summary>
        /// Formats a sequence of <see cref='ITextual'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="delimiter">The cell delimiter</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static string textual<T>(ReadOnlySpan<T> src, string delimiter)
            where T : ITextual
                => concat(items(src),delimiter);
    }
}