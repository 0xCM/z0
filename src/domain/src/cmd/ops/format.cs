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
        public static string format(CmdModel src)
        {
            var buffer = Buffers.text();
            render(src,buffer);
            return buffer.Emit();
        }

        [Op]
        public static string format(in CmdExpr src)
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static string format<K>(in CmdExpr<K> src)
            where K : unmanaged
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static CmdExpr format(in CmdPattern pattern, params CmdVar[] args)
            => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(UnsignedInts)]
        public static CmdExpr format<K>(in CmdPattern<K> pattern, params CmdVar[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdExpr format<K>(in CmdPattern pattern, params CmdVar<K>[] args)
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
            dst.Append(src.Id.Format());
            render(src.Options, dst);
            return dst.Emit();
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

        [Op]
        public static string format(in CmdArgs src)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static string format(in CmdScript src)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
        }
    }
}