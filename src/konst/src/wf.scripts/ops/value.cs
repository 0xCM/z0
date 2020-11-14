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

    partial struct CmdScripts
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ScriptVarValue<T> value<T>(T src)
            => new ScriptVarValue<T>(src);
    }
}