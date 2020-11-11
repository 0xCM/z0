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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> var<K>(K id, in Cell128 value)
            where K : unmanaged
                => new CmdVar<K>(id, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> var<K>(K id, string value)
            where K : unmanaged
                => new CmdVar<K>(id, value);
        [Op]
        public static CmdVars vars(byte count)
            => new CmdVars(new CmdVar[count]);

        [Op]
        public static CmdVars vars()
            => new CmdVars(new CmdVar[MaxVarCount]);

        [Op, Closures(Closure)]
        public static CmdVars<K> vars<K>()
            where K : unmanaged
                => new CmdVars<K>(new CmdVar<K>[MaxVarCount]);
    }
}