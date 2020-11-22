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
    using static Scripts;

    public struct ScriptDirVars : IScriptVars<ScriptDirVars>
    {
        readonly Index<ScriptDirVar> Data;

        [MethodImpl(Inline)]
        internal ScriptDirVars(ScriptDirVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Index<IScriptVar> Members()
            => Data.Storage.Cast<IScriptVar>().Array();

        public string Format()
            => format(this);

        public override string ToString()
            => Format();
    }
}