//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("api")]
    public readonly partial struct Tooling
    {
        [Op]
        public static ToolStatus status(ToolRunner runner)
            => runner.Status();

        [Op]
        public static ref ToolStatus status(ToolRunner runner, ref ToolStatus dst)
            => ref runner.Status(ref dst);

        internal static FolderPath ToolSourceDir
            => FolderPath.Define("J:/assets/tools");

        [MethodImpl(Inline)]
        public static string name<E>(E @enum)
            where E : unmanaged, Enum
        {
            return @enum.ToString();
        }

        [MethodImpl(Inline)]
        public static ToolOption option<E>(E kind, string value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value);

        [MethodImpl(Inline), Op]
        public static ToolOption option(string name, string value)
            => new ToolOption(name, value);

        [MethodImpl(Inline)]
        public static ToolOption value<E,V>(E kind, V value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value.ToString());

        [MethodImpl(Inline), Op]
        public static ToolFlag flag(string name)
            => name;

        [MethodImpl(Inline), Op]
        public static ToolSpec specify(string tool, ToolFlag[] flags, ToolOption[] options)
            => new ToolSpec(tool,flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T>(ToolFlag[] flags, ToolOption[] options)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T,F>(F[] flags, ToolOption[] options, T tool = default)
            where T : unmanaged
            where F : unmanaged, Enum
                => new ToolSpec(typeof(T).Name, flags.Map(f => flag(f.ToString())), options);

    }
}