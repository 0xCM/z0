//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

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

        public static string format(IToolCmd src)
        {
            var count = src.Args.Count;
            var buffer = TextTools.buffer();
            buffer.AppendFormat("{0}{1}", src.CmdId.Format(), Chars.LParen);
            for(var i=0; i<count; i++)
            {
                ref readonly var arg = ref src.Args[i];
                buffer.AppendFormat(RP.Assign, arg.Name, arg.Value);
                if(i != count - 1)
                    buffer.Append(", ");
            }

            buffer.Append(Chars.RParen);
            return buffer.Emit();
        }

    }
}