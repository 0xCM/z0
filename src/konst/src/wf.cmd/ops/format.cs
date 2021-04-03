//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Cmd
    {

        [Op]
        public static string format(CmdVarValue src)
            => src.Content ?? EmptyString;

        [Op]
        public static void render(CmdTypeInfo src, ITextBuffer dst)
        {
            dst.Append(src.DataType.Name);
            var fields = src.Fields.View;;
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,count);
                dst.Append(string.Format(" | {0}:{1}", field.Name, field.FieldType.Name));
            }
        }
    }
}