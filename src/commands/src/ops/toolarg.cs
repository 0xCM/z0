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

    partial struct Cmd
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> toolarg<T>(string name, T value)
            => new ToolCmdArg<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> toolarg<T>(ushort pos, T value)
            => new ToolCmdArg<T>(pos, value);

        [MethodImpl(Inline), Op]
        public static ToolCmdArg<T> toolarg<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new ToolCmdArg<T>(pos, name, value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> toolarg<T>(ushort pos, string name, T value, ArgPrefix prefix, ArgQualifier qualifier)
            => new ToolCmdArg<T>(pos, name, value, (prefix, qualifier));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg<T> toolarg<T>(ushort pos, string name, T value, ArgProtocol protocol)
            => new ToolCmdArg<T>(pos, name, value, protocol);

        [MethodImpl(Inline)]
        public static ToolCmdArg<K,T> toolarg<K,T>(K kind, T value)
            where K : unmanaged
                => new ToolCmdArg<K,T>(kind,value);

        public static ToolCmdArgs toolargs<T>(T src)
            where T : struct, IToolCmd
                => typeof(T).DeclaredInstanceFields().Select(f => new ToolCmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));
    }
}