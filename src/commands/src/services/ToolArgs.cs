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
            where T : struct, IToolCmd
                => typeof(T).DeclaredInstanceFields().Select(f => new ToolCmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));

        [Op]
        public static bool lookup(ToolCmdArgs src, string name, out ToolCmdArg dst)
        {
            var count = src.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var arg = ref src[i];
                if(string.Equals(arg.Name, name, NoCase))
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
            var dst = TextTools.buffer();
            var view = src.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(src,i).Format());
            return dst.Emit();
        }

        [MethodImpl(Inline)]
        public static ToolCmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new ToolCmdArg<K,T>(kind,value);

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
                    return ParseResult.parsed(src, new ToolCmdArg(pos, src));
                else
                    return ParseResult.parsed(src, new ToolCmdArg(pos, src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return ParseResult.unparsed<ToolCmdArg>(src,e);
            }
        }
    }
}