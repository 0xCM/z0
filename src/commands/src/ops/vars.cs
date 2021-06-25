//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Cmd
    {
        internal const byte MaxVarCount = 32;

        [Op]
        public static CmdVars vars(byte count)
            => new CmdVar[count];

        [Op]
        public static CmdVars vars()
            => new CmdVar[MaxVarCount];

        [Op, Closures(Closure)]
        public static Index<CmdVar<K>> vars<K>()
            where K : unmanaged
                => new CmdVar<K>[MaxVarCount];
    }
}