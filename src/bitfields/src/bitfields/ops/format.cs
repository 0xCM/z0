//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static core;

    partial struct BitFields
    {
        [MethodImpl(Inline), Op]
        public static uint render(Bitfield32 src, Span<char> dst)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock64.Null;
            return BitRender.render(n4, bytes, buffer.Data);
        }

        [MethodImpl(Inline), Op]
        public static uint render(Bitfield64 src, Span<char> dst)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock128.Null;
            return BitRender.render(n4, bytes, buffer.Data);
        }

        [Op]
        public static string format(Bitfield32 src)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock64.Null.Data;
            var count = render(src,buffer);
            var chars = slice(buffer,0,count);
            return text.format(chars);
        }

        [Op]
        public static string format(Bitfield64 src)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock128.Null.Data;
            var count = render(src,buffer);
            var chars = slice(buffer,0,count);
            return text.format(chars);
        }

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
            var formatter = bit.formatter<T>(config);
            return text.concat(name, Chars.Colon, formatter.Format(data));
        }
   }
}