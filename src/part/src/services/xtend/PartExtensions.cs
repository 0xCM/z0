//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    using static Part;

    partial class XTend
    {
        public static string Describe(this PartId[] src)
        {
            var count = src.Length;
            var dst = new StringBuilder();
            dst.Append("[");
            var current = string.Empty;
            for(var i=0; i<count; i++)
            {
                var part = src[i];
                if(part != 0)
                {
                    if(i != 0)
                        current += ", ";
                    current += src[i].Format();
                    if(current.Length >= 80)
                    {
                        dst.AppendLine(current);
                        current = string.Empty;
                    }                    
                }
            }

            if(!string.IsNullOrEmpty(current))
            {
                dst.Append("]");
                dst.AppendLine(current);
            }
            else
                dst.AppendLine("]");

            return dst.ToString();
        }

        /// <summary>
        /// Joins the strings provided by the enumerable with an optional separator
        /// </summary>
        /// <param name="src">The source strings</param>
        /// <param name="sep">The separator, if any</param>
        static string Concat(this IEnumerable<string> src, string sep = null)
            => string.Join(sep ?? string.Empty, src);
            
        [MethodImpl(Inline)]
        public static string Format(this PartId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static string Format(this ExternId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }
}