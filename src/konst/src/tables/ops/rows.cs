//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial struct Table
    {
        public static ReadOnlySpan<string> rows<T>(params T[] src)
            where T : struct, ITabular
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            var input = @readonly(src);
            for(var i=0u; i<count; i++)
            {
                seek(dst, i) = skip(input,i).DelimitedText(FieldDelimiter);
            }
            return dst;
        }

        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(ReadOnlySpan<T> src)
            where T : struct
                => rows(index<T>(), src);

        /// <summary>
        /// Allocates a <see cref='DynamicRows{T}' /> index
        /// </summary>
        /// <param name="fields">The fields declared by the defining row</param>
        /// <param name="rowcount">The number of rows to allocate</param>
        /// <typeparam name="T">The row type</typeparam>
        [Op, Closures(Closure)]
        public static DynamicRows<T> rows<T>(in TableFields fields, uint rowcount)
            where T : struct
                => first(recover<byte,DynamicRows<T>>(span<byte>(rowsize<T>(rowcount, fields.Count))));

        [MethodImpl(Inline)]
        public static DynamicRows<T> rows<T>(in TableFields fields, ReadOnlySpan<T> src)
            where T : struct
        {
            var count = (uint)src.Length;
            var buffer = rows<T>(fields, count);
            load(fields,src,buffer);
            return buffer;
        }
    }
}