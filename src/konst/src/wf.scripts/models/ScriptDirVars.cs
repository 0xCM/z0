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

    public struct ScriptDirVars : IScriptVars<ScriptDirVars>
    {
        readonly Indexed<ScriptDirVar> Data;

        [MethodImpl(Inline)]
        internal ScriptDirVars(ScriptDirVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Indexed<IScriptVar> Members()
            => Data.Cast<IScriptVar>();

        public string Format()
            => format(this);

        public override string ToString()
            => Format();
    }
}