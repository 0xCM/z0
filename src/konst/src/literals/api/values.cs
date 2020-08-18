//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Literals
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] values<T>(Type src)
            => map(search<T>(src),value<T>);        

        [MethodImpl(Inline), Op]
        public static void values(in LiteralCover src, Span<object> dst)
            => src.WriteValues(dst);

        [MethodImpl(Inline)]
        public static void values<T>(ref T src, Span<object> dst)
            where T : struct
        {
            var fields = span(typeof(T).DeclaredFields());
            values(ref src, fields, dst);
        }

        [MethodImpl(Inline)]
        public static void values<T>(ref T src, ReadOnlySpan<FieldInfo> fields, Span<object> dst)
            where T : struct
        {
            ref var target = ref first(dst);
            var tRef = __makeref(src);
            var count = fields.Length;
            for(var i=0u; i<count; i++)
                seek(target,i) = skip(fields,i).GetValueDirect(tRef);
        }
    }
}