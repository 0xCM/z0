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

    partial struct TableFields
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
            dst.TableType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.Offset = Interop.offset(src.DeclaringType, src.Name);
            dst.Id = (Address16)dst.Offset;
            dst.RenderWidth = 16;
            dst.Size = default;
            dst.Definition = src;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref TableField map(FieldInfo src, ushort index, byte width, ref TableField dst)
        {
            dst.Index = index;
            dst.TableType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.Offset = Interop.offset(src.DeclaringType, src.Name);
            dst.Id = (Address16)dst.Offset;
            dst.RenderWidth = width;
            dst.Size = default;
            dst.Definition = src;
            return ref dst;
        }
    }
}