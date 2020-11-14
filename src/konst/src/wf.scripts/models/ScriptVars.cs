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

    public struct ScriptVars : IScriptVars<ScriptVars>
    {
        readonly Indexed<ScriptVar> Data;

        [MethodImpl(Inline)]
        internal ScriptVars(ScriptVar[] src)
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