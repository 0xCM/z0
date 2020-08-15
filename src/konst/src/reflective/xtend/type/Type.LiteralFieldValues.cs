//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ReflectionFlags;
    using static z;

    partial class XTend
    {
        /// <summary>
        /// Fetches the values of literal fields declared by a specified type that are of specified parametric type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="fields">The fields for which values are specified</param>
        /// <typeparam name="T">The literal field type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> LiteralFieldValues<T>(this Type src, out ReadOnlySpan<FieldInfo> fields)
        {            
            fields = src.LiteralFields(typeof(T));
            var count = fields.Length;
            var dst = span<T>(fields.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (T)skip(fields,i).GetRawConstantValue();
            return dst;
        }
    }
}