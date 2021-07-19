//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    partial struct Cmd
    {
        internal const byte MaxVarCount = 32;

        [Op]
        public static CmdVars vars(byte count)
            => new CmdVar[count];

        public static CmdVars vars(params Pair<string>[] src)
        {
            var dst = new CmdVar[MaxVarCount];
            var count = min(src.Length,src.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            return dst;
        }


        [Op]
        public static CmdVars vars()
            => new CmdVar[MaxVarCount];

        [Op, Closures(Closure)]
        public static Index<CmdVar<K>> vars<K>()
            where K : unmanaged
                => new CmdVar<K>[MaxVarCount];
    }
}