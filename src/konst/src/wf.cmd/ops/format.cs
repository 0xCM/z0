//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [Op]
        public string format(CmdSpec src)
        {
            var dst = Buffers.text();
            dst.AppendFormat("{0} ", src.CmdId.Format());
            CmdArgs.render(src.Args,dst);
            return dst.Emit();
        }

        [Op]
        public static void render(CmdTypeInfo src, ITextBuffer dst)
        {
            dst.Append(src.DataType.Name);
            var fields = src.Fields.Terms;;
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,count);
                dst.Append(string.Format(" | {0}:{1}", field.Name, field.FieldType.Name));
            }
        }

        [Op]
        public static string format(CmdTypeInfo src)
        {
            var buffer = Buffers.text();
            render(src,buffer);
            return buffer.Emit();
        }

        [Op]
        public static string format(in CmdSpec src)
        {
            var dst = Buffers.text();
            dst.Append(src.CmdId.Format());
            CmdArgs.render(src.Args, dst);
            return dst.Emit();
        }
    }
}