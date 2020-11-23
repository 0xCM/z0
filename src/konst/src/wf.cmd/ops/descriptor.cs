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
        public static CmdDescriptor descriptor(Type src)
            => new CmdDescriptor(src, src.DeclaredInstanceFields());

        public static CmdDescriptor<T> descriptor<T>()
            where T : struct, ICmdSpec<T>
                => default;

        [Op]
        public static CmdDescriptor[] descriptors(IWfShell wf)
            => typeof(Cmd).Assembly.Types().Tagged<CmdAttribute>().Select(descriptor);
    }
}