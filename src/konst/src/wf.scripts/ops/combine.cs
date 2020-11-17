//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [MethodImpl(Inline), Op]
        public static ScriptSymbol combine(ScriptSymbol a, ScriptSymbol b)
            => new ScriptSymbol(string.Format("{0}{1}", a, b));

        [MethodImpl(Inline), Op]
        public static ScriptSymbol combine<T>(ScriptSymbol<T> a, ScriptSymbol<T> b)
            => new ScriptSymbol(string.Format("{0}{1}", a,b));

    }
}