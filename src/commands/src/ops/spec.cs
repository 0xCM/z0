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
        [Op, Closures(Closure)]
        public static CmdSpec<K> spec<K>(K id, StringIndex args)
            where K : unmanaged
                => new CmdSpec<K>(id,args);

        [Op, MethodImpl(Inline)]
        public static CmdSpec spec(string name, CmdArgs args)
            => new CmdSpec(name,args);
    }
}