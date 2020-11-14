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

    partial struct Scripts
    {
        [MethodImpl(Inline), Op]
        public static ScriptVar set(ScriptVar src, ScriptVarValue value)
            =>  var(src.Symbol, value);

        [MethodImpl(Inline), Op]
        public static ScriptDirVar set(ScriptDirVar src, ScriptVarValue value)
            =>  dir(src.Symbol, value);
    }
}