//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    partial class XTend
    {
        /// <summary>
        /// Formats each source element on a new line
        /// </summary>
        /// <param name="src">The source span</param>
        public static string FormatLines<T>(this ReadOnlySpan<T> src)
        {
            var lines = string.Empty.Build();
            for(var i=0; i<src.Length; i++)
                lines.AppendLine(src[i].ToString());
            return lines.ToString();
        }

        /// <summary>
        /// Formats each source element on a new line
        /// </summary>
        /// <param name="src">The source span</param>
        public static string FormatLines<T>(this Span<T> src)
            => src.ReadOnly().FormatLines();

    }
}