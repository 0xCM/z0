//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Formats a type that provides intrinsic format capability
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string Format<T>(this T src)
            where T : ICustomFormattable
                => src.Format();

        public static string Format<T>(this ReadOnlySpan<T> src, char sep = Chars.Comma, int offset = 0, int pad = 0, bool bracketed = true)
        {
            if(src.Length == 0)
                return string.Empty;

            var sb = text.build();
            
            for(var i = offset; i< src.Length; i++)
            {
                var item =$"{src[i]}";
                sb.Append(pad != 0 ? item.PadLeft(pad) : item);                
                if(i != src.Length - 1)
                {
                    sb.Append(sep);
                    sb.Append(Chars.Space);
                }
            }
            return bracketed ? $"[{sb.ToString()}]" : sb.ToString();
        }

        public static string Format<T>(this Span<T> src, char sep = Chars.Comma, int offset = 0, int pad = 0, bool bracketed = true)
            => src.ReadOnly().Format(sep,offset,pad, bracketed);

        public static string Format<T>(this T[] src, char sep = Chars.Comma, int offset = 0, int pad = 0, bool bracketed = true)
            => src.ToSpan().Format(sep, offset);
    }
}