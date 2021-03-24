//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ToolCmd
    {
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

        [MethodImpl(Inline)]
        public static CmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new CmdArg<K,T>(kind,value);

        [Op]
        public static ParseResult<ToolCmdArg> arg(ushort pos, string src, char qualifier = ' ')
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