//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static void render(TableFields fields, object src, StringBuilder dst, bool eol = true)
        {
            var count = fields.Count;
            var view = fields.View;
            var tref = __makeref(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(view,i);
                dst.Append(text.format(value(field.Definition, tref), field.DataType, FieldDelimiter, field.RenderWidth.Value));
            }

            if(eol)
                dst.Append(Eol);
        }

        [MethodImpl(Inline)]
        public static void render<T>(TableFields fields, in T src, StringBuilder dst, bool eol = true)
            where T : struct
        {
            var count = fields.Count;
            var view = fields.View;
            var tref = __makeref(edit(src));
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(view,i);
                dst.Append(text.format(value(field.Definition, tref), field.DataType, FieldDelimiter, field.RenderWidth.Value));
            }

            if(eol)
                dst.Append(Eol);
        }
    }
}