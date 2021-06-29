//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Bitfields
    {
        [Op]
        public static string format(Bitfield8 src)
            => TextTools.format(render(src));

        [Op]
        public static string format(Bitfield16 src)
            => TextTools.format(render(src));

        [Op]
        public static string format(Bitfield32 src)
            => TextTools.format(render(src));

        [Op]
        public static string format(Bitfield64 src)
            => TextTools.format(render(src));

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
                => format<E,T>(src, typeof(E).Name, zpad);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, string name, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = Enums.scalar<E,T>(src);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormat.limited(limit,zpad);
            var formatter = BitRender.formatter<T>(config);
            return string.Concat(name, Chars.Colon, formatter.Format(data));
        }
    }
}