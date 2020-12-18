//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        internal const byte MaxVarCount = 16;

        [Op]
        public static CmdVarIndex vars(byte count)
            => new CmdVarIndex(new CmdVar[count]);

        [Op]
        public static CmdVarIndex vars()
            => new CmdVarIndex(new CmdVar[MaxVarCount]);

        [Op, Closures(Closure)]
        public static CmdVarIndex<K> vars<K>()
            where K : unmanaged
                => new CmdVarIndex<K>(new CmdVar<K>[MaxVarCount]);
    }
}