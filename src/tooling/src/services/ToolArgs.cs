//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct ToolArgs
    {
        const NumericKind Closure = UnsignedInts;

        public static ToolCmdArgs args<T>(T src)
            where T : struct, IToolCmd<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new ToolCmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));


        [Op]
        public static bool lookup(ToolCmdArgs src, string name, out ToolCmdArg dst)
        {
            var count = src.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var arg = ref src[i];
                if(text.equals(arg.Name, name))
                {
                    dst=arg;
                    return true;
                }
            }
            dst = ToolCmdArg.Empty;
            return false;
        }

        public static string format<K,T>(in ToolCmdArgs<K,T> src)
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
        public static ToolCmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new ToolCmdArg<K,T>(kind,value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        [Op]
        public static string format(in ToolCmdArg src)
            => string.Format(RP.Assign, src.Name, src.Value);

        /// <summary>
        /// Renders a specified option as text
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [Op, Closures(Closure)]
        public static string format<T>(in ToolCmdArg<T> src)
            => string.Format(RP.Assign, src.Name, src.Value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> arg<T>(string name, T value)
            => new ToolCmdArg<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> arg<T>(ushort pos, T value)
            => new ToolCmdArg<T>(pos, value);

        [MethodImpl(Inline), Op]
        public static ToolCmdArg<T> arg<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new ToolCmdArg<T>(pos, name, value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> arg<T>(ushort pos, string name, T value, ArgPrefix prefix, ArgQualifier qualifier)
            => new ToolCmdArg<T>(pos, name, value, (prefix, qualifier));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> arg<T>(ushort pos, string name, T value, ArgProtocol protocol)
            => new ToolCmdArg<T>(pos, name, value, protocol);

        [Op]
        public static ParseResult<ToolCmdArg> parse(ushort pos, string src, char qualifier = ' ')
        {
            try
            {
                var i = src.IndexOf(qualifier);
                if(i == NotFound)
                    return root.parsed(src, new ToolCmdArg(pos, src));
                else
                    return root.parsed(src, new ToolCmdArg(pos, src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return root.unparsed<ToolCmdArg>(src,e);
            }
        }
    }
}