//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Address16> offsets(Type src)
        {
            var fields = span(src.DeclaredFields());
            var count = fields.Length;
            var dst = span<Address16>(count);
            offsets(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void offsets(Type src, Span<Address16> dst)
        {
            var fields = span(src.DeclaredFields());
            offsets(src,fields,dst);
        }

        [MethodImpl(Inline), Op]
        public static void offsets(Type src, ReadOnlySpan<FieldInfo> fields, Span<Address16> dst)
        {
            var count = fields.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(dst,i) = (ushort)Marshal.OffsetOf(src,f.Name);
            }
        }
    }
}