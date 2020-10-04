//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Text;

    using static Konst;
    using static z;

    partial struct TableFields
    {
        public static void header(in TableFieldIndex src, char Delimiter, StringBuilder dst)
        {
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(view,i);
                var width = field.RenderWidth;
                var label = $"{Delimiter} {field.Name}";
                dst.Append(label.PadRight(width));
            }
        }

        [MethodImpl(Inline), Op]
        static object value(FieldInfo def, TypedReference tr)
            => def.GetValueDirect(tr);

        public static void format<F,T>(in TableFieldIndex<F> fields, in T src, StringBuilder dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            var count = fields.Count;
            var view = fields.View;
            var tt = typeof(T);
            var tr = __makeref(edit(src));
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(view,i);
                var width = field.Width;
                var type = field.DataType;
                var def = field.Definition;
                var val = value(def,tr);
                var fmt = text.format(val, type, FieldDelimiter, width);
                dst.Append(fmt);
            }
        }

        public static void format<F,T>(in T src, StringBuilder dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            format(index<F,T>(), src, dst);
        }

        public static string format<F,T>(in T src)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            var dst = text.build();
            format(index<F,T>(), src, dst);
            return dst.ToString();
        }
    }
}