//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFields
    {
        public static string format<T>(in BitfieldCover<T> src)
            where T : unmanaged
        {
            var dst = text.buffer();
            render(src,dst);
            return dst.Emit();
        }

        [Op, Closures(UInt64k)]
        public static void render<T>(in BitfieldCover<T> src, ITextBuffer dst)
            where T : unmanaged
        {
            var count = src.Spec.FieldCount;
            var last = count - 1;
            dst.Append(Chars.LBracket);

            for(var i=last; i>=0; i--)
            {
                ref readonly var seg = ref src.Segment((byte)i);
                dst.AppendFormat("{0}:{1}", seg.Name, bit.format(src.Extract((byte)i), seg.Width));

                if(i != 0)
                    dst.Append(RP.SpacedPipe);

            }
            dst.Append(Chars.RBracket);
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