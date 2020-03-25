//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Texting;

    partial class TextingOps
    {
        public static string Concat(this ReadOnlySpan<string> src, string delimiter = null)
        {
            var dst = builder();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter);                
                dst.Append(src[i]);            
            }
            return dst.ToString();
        }

        public static string Concat(this ReadOnlySpan<string> src, char? delimiter)
        {
            var dst = builder();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter.Value);                
                dst.Append(src[i]);            
            }
            return dst.ToString();
        }

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Concat(this ReadOnlySpan<char> src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Concat(this Span<char> src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<char> Concat(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => lhs.Concat() + rhs.Concat();

        public static string Concat(this Span<string> src, string sep)
        {
            var dst = builder();
            for(var i=0; i<src.Length; i++)   
            {
                ref var cell = ref src[i];
                if(i != src.Length - 1)
                    dst.Append($"{cell}{sep}");
                else
                    dst.Append(cell);
            }
            return dst.ToString();
        }

        public static string Concat(this Span<string> src)
            => src.Concat(string.Empty);

        public static string Concat(this Span<string> src, char sep)
            => src.Concat(sep.ToString());
    }
}