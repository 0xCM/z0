//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ToolCmd
    {
        [MethodImpl(Inline), Op]
        public static ScriptExpr expr(ScriptPattern pattern)
            => new ScriptExpr(pattern);

        [MethodImpl(Inline), Op]
        public static ScriptExpr expr(in Paired<ScriptPattern,CmdVarIndex> src)
            => new ScriptExpr(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public static ScriptExpr expr(ScriptPattern pattern, CmdVarIndex vars)
            => new ScriptExpr(pattern, vars);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ScriptExpr<K> expr<K>(ScriptPattern pattern, CmdVarIndex<K> content)
            where K : unmanaged
                => new ScriptExpr<K>(pattern, content);

        [MethodImpl(Inline)]
        public static ScriptExpr<K,T> expr<K,T>(K id, T content)
            where K : unmanaged
                => new ScriptExpr<K,T>(id,content);
    }
}