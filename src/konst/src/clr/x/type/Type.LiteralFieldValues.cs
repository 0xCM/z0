//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static memory;

    partial class ClrQuery
    {
        /// <summary>
        /// Fetches the values of literal fields declared by a specified type that are of specified parametric type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="fields">The fields for which values are specified</param>
        /// <typeparam name="T">The literal field type</typeparam>
        [Op, Closures(Closure)]
        public static ReadOnlySpan<T> LiteralFieldValues<T>(this Type src, out ReadOnlySpan<FieldInfo> fields)
        {
            fields = src.LiteralFields(typeof(T));
            var count = fields.Length;
            var dst = span<T>(fields.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (T)skip(fields,i).GetRawConstantValue();
            return dst;
        }

        /// <summary>
        /// Fetches the values of literal fields declared by a specified type that are of specified parametric type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="fields">The fields for which values are specified</param>
        /// <typeparam name="T">The literal field type</typeparam>
        [Op, Closures(Closure)]
        public static Index<T> LiteralFieldValues<T>(this Type src)
        {
            var fields = src.LiteralFields(typeof(T));
            var count = fields.Length;
            var dst = alloc<T>(fields.Length);
            ref var target = ref first(dst);
            for(var i=0u; i<count; i++)
                seek(target, i) = (T)skip(fields, i).GetRawConstantValue();
            return dst;
        }
    }
}