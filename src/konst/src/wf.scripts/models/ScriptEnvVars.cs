//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static Scripts;

    public struct ScriptEnvVars : IScriptVars<ScriptEnvVars>
    {
        public ScriptDirVar DevRoot;

        public ScriptDirVar Db;

        public ScriptDirVar Control;

        [MethodImpl(Inline)]
        public Index<IScriptVar> Members()
            => members(this);

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

        public override string ToString()
            => Format();
    }
}