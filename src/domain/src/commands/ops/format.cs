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
        [MethodImpl(NotInline), Op]
        public static string format(CmdLinePattern pattern, params object[] args)
            => string.Format(pattern.Text, args);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static string format(in CmdOption src)
            => Render.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(in CmdOption<T> src)
            => Render.setting(src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<K,T>(in CmdOption<K,T> src)
            where K : unmanaged
                => Render.setting(src.Name, src.Value);

        public static string format<K,T>(in CmdOptions<K,T> src)
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
        public static string format(in CmdOptions src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }

        [Op]
        public static void render(in CmdOptions src, ITextBuffer dst)
        {
            var view = src.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(view,i).Format());
        }

        // [Op]
        // public static string format(in CmdLine src)
        // {
        //     var dst = text.build();
        //     dst.Append(src.ToolName);
        //     var count = src.OptionCount;
        //     var options = src.Options.View;
        //     for(var i=0; i<count; i++)
        //     {
        //         dst.Append(Space);
        //         dst.Append(format(skip(options,i)));
        //     }

        //     return dst.ToString();
        // }
    }
}