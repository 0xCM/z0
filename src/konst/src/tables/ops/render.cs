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
        public static void render<T>(TableFields fields, in T src, StringBuilder dst, bool eol = true)
            where T : struct
        {
            var count = fields.Count;
            var view = fields.View;
            var tref = __makeref(edit(src));
            for(var i=0u; i<count; i++)
            {
                try
                {
                    ref readonly var field = ref skip(view,i);
                    var v = Clr.value(field.Definition, tref);
                    dst.Append(text.format(v, field.DataType, FieldDelimiter, field.RenderWidth));
                }
                catch(Exception e)
                {
                    dst.Append(e.Message);
                }
            }

            if(eol)
                dst.Append(Eol);
        }
    }
}