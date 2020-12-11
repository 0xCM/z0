//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static z;
    using static Konst;

    public struct CmdScriptVars : ICmdVars<CmdScriptVars>
    {
        readonly Index<CmdScriptVar> Data;

        [MethodImpl(Inline)]
        internal CmdScriptVars(CmdScriptVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Index<ICmdVar> Members()
            => new Index<ICmdVar>(Data.Storage.Select(x => z.cast<ICmdVar>(x)));

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();
    }
}