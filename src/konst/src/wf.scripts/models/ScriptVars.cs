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
    using static CmdScripts;

    public struct ScriptVars : IScriptVars<ScriptVars>
    {
        readonly Indexed<ScriptDir> Directories;

        [MethodImpl(Inline)]
        internal ScriptVars(ScriptDir[] src)
        {
            Directories = src;
        }

        public Indexed<IScriptVar> Members()
            => Directories.Cast<IScriptVar>();

        public string Format()
            => format(this);

        public override string ToString()
            => Format();
    }
}