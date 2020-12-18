//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public struct CmdScriptVars : ICmdVars<CmdScriptVars>
    {
        readonly Index<CmdScriptVar> Data;

        [MethodImpl(Inline)]
        internal CmdScriptVars(CmdScriptVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Index<ICmdVar> Members()
            => new Index<ICmdVar>(Data.Storage.Select(x => cast<ICmdVar>(x)));

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();
    }
}