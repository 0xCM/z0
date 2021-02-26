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
        public static string format<T>(ICmd<T> src)
            where T : struct, ICmd<T>
        {
            var buffer = Buffers.text();
            buffer.AppendFormat("{0}{1}", src.CmdName, Chars.LParen);

            var fields = ClrFields.instance(typeof(T));
            if(fields.Length != 0)
                render(__makeref(src), fields, buffer);

            buffer.Append(Chars.RParen);
            return buffer.Emit();
        }

        [Op]
        static void render(TypedReference src, ReadOnlySpan<ClrField> fields, ITextBuffer dst)
        {
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                dst.AppendFormat(RP.Assign, field.Name, field.GetValueDirect(src));
                if(i != count - 1)
                    dst.Append(", ");
            }
        }

        [Op]
        public static string format(ICmd src)
        {
            var count = src.Args.Count;
            var buffer = Buffers.text();
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

        [MethodImpl(Inline), Formatter, Closures(Closure)]
        public static string format<K>(in CmdOptionSpec<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [Op]
        public static string format(CmdVarValue src)
            => src.Content ?? EmptyString;

        public static string format<K,T>(in CmdArgs<K,T> src)
            where K : unmanaged
        {
            var dst = text.build();
            var view = src.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(src,i).Format());
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string Format(in CmdArg src)
            => text.nonempty(src.Name)
             ? string.Format(RP.Setting, src.Name, src.Value)
             : src.Value?.ToString() ?? EmptyString;


        [MethodImpl(Inline), Formatter]
        public static string format(CmdOptionSpec src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static string format(in CmdArg src)
            => TextFormatter.assign(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in CmdArg<T> src)
            => TextFormatter.assign(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
                => TextFormatter.assign(src.Kind.ToString(), src.Value);
        [Op]
        public static string format(CmdTypeInfo src)
        {
            var buffer = Buffers.text();
            render(src, buffer);
            return buffer.Emit();
        }

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