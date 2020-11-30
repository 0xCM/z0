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

    [ApiHost]
    public readonly partial struct CmdFormat
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static string format(in CmdFlagSpec src)
            => src.Name.IsEmpty ? src.Index.ToString() : string.Format("{0}:{1}", src.Name, src.Index);

        [Op]
        public static void render(CmdArgIndex src, ITextBuffer dst)
        {
            var count = src.Count;
            for(var i=0u; i<count; i++)
            {
                dst.Append(format(src[i]));
                if(i != count - 1)
                    dst.Append(Space);
            }
        }

        [Op]
        public static string format(in CmdArgIndex src)
        {
            var dst = Buffers.text();
            render(src, dst);
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
        public string format(CmdSpec src)
        {
            var dst = Buffers.text();
            dst.AppendFormat("{0} ", src.CmdId.Format());
            CmdFormat.render(src.Args,dst);
            return dst.Emit();
        }

        [Op]
        public static string format(in CmdSpec src)
        {
            var dst = Buffers.text();
            dst.Append(src.CmdId.Format());
            CmdFormat.render(src.Args, dst);
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

        [MethodImpl(Inline), Formatter]
        public static string format(CmdOptionSpec src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [MethodImpl(Inline), Formatter, Closures(UnsignedInts)]
        public static string format<K>(CmdOptionSpec<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [Op]
        public static void render(DirVars src, ITextBuffer dst)
        {
            var members = src.Members().View;
            var count = members.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(format(skip(members,i)));
        }

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
        public static string format(CmdVarSymbol src)
            => string.Format("$({0})",src.Name ?? EmptyString);

        [Op]
        public static string format(ICmdVars src)
        {
            var dst = text.build();
            foreach(var member in src.Members())
                dst.AppendLine(format(member));
            return dst.ToString();
        }

    }
}