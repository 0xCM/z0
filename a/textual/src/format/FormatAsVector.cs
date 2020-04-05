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
        /// Formats a readonly span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatAsVector<T>(this ReadOnlySpan<T> src, string sep = ",")
        {
            var components = src.Map(x => x.ToString());
            var body = components.Concat(sep);
            return Chars.Lt + body + Chars.Gt;
        }
 
        /// <summary>
        /// Formats a span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatAsVector<T>(this Span<T> src, string sep = ",")
            => src.ReadOnly().FormatAsVector(sep);        
    }
}