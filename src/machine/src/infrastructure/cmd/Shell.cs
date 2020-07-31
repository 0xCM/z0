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
        public static CmdSpec ildasm(IlDasm.FlagKind[] flags, CmdOption[] options)
            => cmd(flags, options, default(IlDasm));

        [MethodImpl(Inline), Op]
        public static CmdOption option(IlDasm.OptionKind kind, string value)
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
        public static CmdOption value<E>(E kind, string value)
            where E : unmanaged, Enum
                => new CmdOption(kind.ToString(), value);

        [MethodImpl(Inline)]
        public static CmdOption value<E,V>(E kind, V value)
            where E : unmanaged, Enum
                => new CmdOption(kind.ToString(), value.ToString());
        
        [MethodImpl(Inline), Op]
        public static CmdFlag flag(string name)
            => name;

        [MethodImpl(Inline), Op]
        public static CmdOption option(string name, string value)
            => new CmdOption(name, value);

        [MethodImpl(Inline), Op]
        public static CmdSpec cmd(string tool, CmdFlag[] flags, CmdOption[] options)            
            => new CmdSpec(tool,flags,options);

        [MethodImpl(Inline)]
        public static CmdSpec cmd<T>(CmdFlag[] flags, CmdOption[] options)            
            where T : unmanaged, ICmdTool<T>
                => new CmdSpec(default(T).Name, flags,options);            

        [MethodImpl(Inline)]
        public static CmdSpec cmd<T,F>(F[] flags, CmdOption[] options, T tool = default)            
            where T : unmanaged, ICmdTool<T,F>
            where F : unmanaged, Enum
                => new CmdSpec(default(T).Name, flags.Map(f => flag(f.ToString())), options);            
    }
}