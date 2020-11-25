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
        public static string format(in CmdScriptExpr src)
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static string format<K>(in CmdScriptExpr<K> src)
            where K : unmanaged
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static CmdScriptExpr format(in CmdPattern pattern, params CmdVar[] args)
            => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(UnsignedInts)]
        public static CmdScriptExpr format<K>(in CmdPattern<K> pattern, params CmdVar[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern pattern, params CmdVar<K>[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static string format(in CmdArg src)
            => Render.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in CmdArg<T> src)
            => Render.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
                => Render.setting(src.Key, src.Value);
        [Op]
        public static string format(in CmdSpec src)
        {
            var dst = Buffers.text();
            dst.Append(src.CmdId.Format());
            CmdArgs.render(src.Args, dst);
            return dst.Emit();
        }

        public static string format<K,T>(in CmdArgIndex<K,T> src)
            where K : unmanaged
        {
            var dst = text.build();
            var view = src.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(src,i).Format());
            return dst.ToString();
        }

        [Op]
        public static string format(in CmdArgIndex src)
        {
            var dst = Buffers.text();
            CmdArgs.render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static string format(in CmdScript src)
        {
            var dst = Buffers.text();
            WfScripts.render(src, dst);
            return dst.Emit();
        }

        [Formatter]
        public static string format(CmdArgPrefix src)
        {
            var len = src.Length;
            if(len == 0)
                return EmptyString;
            else if(len == 1)
            {
                Span<char> content = stackalloc char[1]{(char)src.C0};
                return new string(content);
            }
            else
            {
                Span<char> content = stackalloc char[2]{(char)src.C0, (char)src.C1};
                return new string(content);
            }
        }
    }
}