//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct MemRefs
    {
        public static string[] format<E>(MemorySlots<E> src)
            where E : unmanaged
        {
            var dst = sys.alloc<string>(src.Length);
            format(src,dst);
            return dst;
        }

        [Op, Closures(Closure)]
        public static void format<E>(MemorySlots<E> src, Span<string> dst)
            where E : unmanaged
        {
            var count = src.Length;
            ref readonly var lead = ref src.Lookup(default(E));
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(lead,i).Format();
        }

        /// <summary>
        /// Formats the source argument according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0)
            => text.format(pattern.Format(), arg0.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1)
            => text.format(pattern.Format(), arg0.Format(), arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in StringRef arg0, in StringRef arg1)
            => text.format(pattern, arg0, arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in string arg0, in StringRef arg1)
            => text.format(pattern, arg0, arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1, in StringRef arg2)
            => text.format(pattern.Format(), arg0.Format(), arg1.Format(), arg2.Format());

        [Op]
        public static string join(string delimiter, params StringRef[] refs)
        {
            var dst = text.build();
            var src = span(refs);
            var count = src.Length;

            for(var i=0u; i<count; i++)
            {
                var s = z.skip(src,i).Text;
                dst.Append(s);
                if(i != count - 1)
                    dst.Append(delimiter);
            }

            return dst.ToString();
        }
    }
}