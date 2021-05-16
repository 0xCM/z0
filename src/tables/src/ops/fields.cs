//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct Tables
    {
        public static Index<string> fields(string src, char delimiter)
            => text.split(text.trim(src), delimiter);

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a parametrically-identified record type
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(Closure)]
        public static RecordFields fields<T>()
            where T : struct
                => fields(typeof(T));

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static RecordFields fields(Type src)
        {
            var fields = src.DeclaredPublicInstanceFields();
            var count = fields.Length;
            var dst = sys.alloc<RecordField>(count);
            map(fields,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        static ref RecordField map(FieldInfo src, ushort index, ref RecordField dst)
        {
            dst.FieldIndex = index;
            dst.Definition = src;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        static ref RecordField<T> map<T>(FieldInfo src, ushort index, ref RecordField<T> dst)
            where T : struct, IRecord<T>
        {
            dst.FieldIndex = index;
            dst.Definition = src;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        static void map(ReadOnlySpan<FieldInfo> src, Span<RecordField> dst)
        {
            var count = (ushort)src.Length;
            for(var i=z16; i<count; i++)
                map(skip(src, i), i, ref seek(dst, i));
        }
    }
}