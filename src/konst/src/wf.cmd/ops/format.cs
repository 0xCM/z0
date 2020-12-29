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
    using static CmdVarTypes;

    partial struct Cmd
    {
        [Op]
        public static string format(CmdScriptVar src)
            => string.Format("{0}={1}",src.Symbol, src.Value);

        [Op]
        public static string format(in CmdScript src)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
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

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern<K> pattern, params CmdVar[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern pattern, params CmdVar<K>[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op]
        public static string format(in CmdFlagSpec src)
            => src.Name.IsEmpty ? src.Index.ToString() : string.Format("{0}:{1}", src.Name, src.Index);

        [MethodImpl(Inline), Formatter, Closures(Closure)]
        public static string format<K>(in CmdOptionSpec<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [Op, Closures(Closure)]
        public static string format<T>(CmdVarSymbol<T> src)
            => string.Format("{0}", src.Name);

        [Op]
        public static string format(CmdVarValue src)
            => src.Content ?? EmptyString;

        [Op]
        public static string format(ICmdVar src)
            => string.Format("{0}={1}", src.Symbol, src.Value);

        [Op]
        public static string format(ICmdVars src)
        {
            var dst = text.build();
            foreach(var member in src.Members())
                dst.AppendLine(format(member));
            return dst.ToString();
        }

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

        public static string format<T>(T src)
            where T : ICmdSpec
        {
            var dst = Buffers.text();
            dst.Append(src.CmdId.Format());
            dst.Append("[");
            for(var i=0; i<src.Args.Count; i++)
            {
                ref readonly var arg = ref src.Args[i];
                dst.Append(arg.Format());
                dst.Append(Space);
            }

            dst.Append("]");
            return dst.Emit();

        }

        [MethodImpl(Inline)]
        public static string Format(in CmdArg src)
            => text.nonempty(src.Name)
             ? string.Format(RP.Setting, src.Name, src.Value)
             : src.Value?.ToString() ?? EmptyString;


        [MethodImpl(Inline), Formatter]
        public static string format(CmdOptionSpec src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [Formatter]
        public static string format(ArgPrefix src)
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

        [Op]
        public static string format(CmdVarSymbol src)
            => string.Format("$({0})",src.Name ?? EmptyString);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static string format(in CmdArg src)
            => TextFormatter.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in CmdArg<T> src)
            => TextFormatter.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
                => TextFormatter.setting(src.Kind, src.Value);
        [Op]
        public static string format(CmdTypeInfo src)
        {
            var buffer = Buffers.text();
            render(src,buffer);
            return buffer.Emit();
        }

        [Op]
        public static void render(CmdScript src, ITextBuffer dst)
        {
            var count = src.Length;
            var parts = src.View;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(parts,i).Format());
        }

        [Op]
        public static void render(DirVars src, ITextBuffer dst)
        {
            var members = src.Members().View;
            var count = members.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(format(skip(members,i)));
        }

        [Op]
        public static void render(CmdArgs src, ITextBuffer dst)
        {
            var count = src.Count;
            for(var i=0u; i<count; i++)
            {
                dst.Append(Cmd.format(src[i]));
                if(i != count - 1)
                    dst.Append(Space);
            }
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

    }
}