//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Materializes the constructed string
        /// </summary>
        /// <param name="src">The source string</param>
        public static string format(StringBuilder src)
            => src.ToString();

        /// <summary>
        /// Formats a custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string format<T>(T src)
            where T : ITextual
                => denullify(src?.Format());

        /// <summary>
        /// Produces a sequence of formatted strings given a sequence of custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<string> format<T>(IEnumerable<T> src)
            where T : ITextual
                => src.Select(x => x.Format());

        public static string format<T>(IEnumerable<T> src, string delimiter = null)
            where T : ITextual
        {
            var dst = build();
            var count = 0;
            var sep = denullify(delimiter);
            
            void append(T item)
            {
                if(count != 0)
                    dst.Append(sep);
                 dst.Append(item.Format());   
            }

            return format(dst);
        }


        /// <summary>
        /// Formats and concatenates an arbitrary number of elements
        /// </summary>
        /// <param name="rest">The formattables to be rendered and concatenated</param>
        public static string format(object first, params object[] rest)
            => (first?.ToString() ?? EmptyString) + concat(rest.Select(x => x.ToString()));        
    }
}