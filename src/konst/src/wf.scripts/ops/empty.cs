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
        public static bool empty<T>(ScriptVarValue<T> src)
            => src.Content?.Equals(default(T)) ?? true;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool nonempty<T>(ScriptVarValue<T> src)
            => !empty(src);
    }
}