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

    using api = Scripts;

    partial struct Scripts
    {
        public struct ScriptVars : IScriptVars<ScriptVars>
        {
            readonly Indexed<Dir> Directories;

            [MethodImpl(Inline)]
            internal ScriptVars(Dir[] src)
            {
                Directories = src;
            }

            public Indexed<IScriptVar> Members()
                => Directories.Cast<IScriptVar>();

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}