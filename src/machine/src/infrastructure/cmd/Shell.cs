//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Cmd;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Shell
    {
        [MethodImpl(Inline), Op]
        public static ToolSpec ildasm(IlDasm.FlagKind[] flags, ToolOption[] options)
            => cmd(flags, options, default(IlDasm));

        [MethodImpl(Inline), Op]
        public static ToolOption option(IlDasm.OptionKind kind, string value)
            => Shell.value(kind, value);

        [MethodImpl(Inline), Op]
        public static string name(IlDasm.FlagKind @enum)
            => gname(@enum);
        

        [MethodImpl(Inline)]
        public static string gname<E>(E @enum)
            where E : unmanaged, Enum
        {
            return @enum.ToString();
        }

        [MethodImpl(Inline)]
        public static ToolOption value<E>(E kind, string value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value);

        [MethodImpl(Inline)]
        public static ToolOption value<E,V>(E kind, V value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value.ToString());
        
        [MethodImpl(Inline), Op]
        public static ToolFlag flag(string name)
            => name;

        [MethodImpl(Inline), Op]
        public static ToolOption option(string name, string value)
            => new ToolOption(name, value);

        [MethodImpl(Inline), Op]
        public static ToolSpec cmd(string tool, ToolFlag[] flags, ToolOption[] options)            
            => new ToolSpec(tool,flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec cmd<T>(ToolFlag[] flags, ToolOption[] options)            
            where T : unmanaged, ICmdTool<T>
                => new ToolSpec(default(T).Name, flags,options);            

        [MethodImpl(Inline)]
        public static ToolSpec cmd<T,F>(F[] flags, ToolOption[] options, T tool = default)            
            where T : unmanaged, ICmdTool<T,F>
            where F : unmanaged, Enum
                => new ToolSpec(default(T).Name, flags.Map(f => flag(f.ToString())), options);            
    }
}