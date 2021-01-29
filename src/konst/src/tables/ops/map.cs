//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static void map(ReadOnlySpan<FieldInfo> src, Span<TableField> dst)
        {
            var count = (ushort)src.Length;
            for(var i=z16; i<count; i++)
                map(skip(src, i), i, ref seek(dst, i));
        }

        [MethodImpl(Inline), Op]
        public static ref TableField map(FieldInfo src, ushort index, ref TableField dst)
        {
            dst.Index = index;
            dst.RecordType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.RenderWidth = 16;
            dst.Definition = src;
            return ref dst;
        }

    }
}