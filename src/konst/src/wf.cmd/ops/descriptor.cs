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
        public static CmdTypeInfo descriptor(Type src)
            => new CmdTypeInfo(src, src.DeclaredInstanceFields());

        public static CmdTypeInfo<T> descriptor<T>()
            where T : struct, ICmdSpec<T>
                => default;

        [Op]
        public static CmdTypeInfo[] descriptors(IWfShell wf)
            => typeof(Cmd).Assembly.Types().Tagged<CmdAttribute>().Select(descriptor);
    }
}