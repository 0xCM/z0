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

    [ApiHost(ApiNames.Cmd, true)]
    public readonly partial struct Cmd
    {
        [Op]
        public static int execute(IWfShell wf, CmdId id, params CmdOption[] options)
        {
            return 0;
        }

        [MethodImpl(Inline)]
        public static asci32 name<K,T>(in CmdOption<K,T> src)
            where K : unmanaged
                => src.Kind.ToString().ToLower();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static CmdHost<T> host<T>(T t = default)
            where T : struct
                => CmdHost<T>.create();

        [MethodImpl(Inline), Op]
        public static CmdOptions options(params CmdOption[] src)
            => src;
    }
}