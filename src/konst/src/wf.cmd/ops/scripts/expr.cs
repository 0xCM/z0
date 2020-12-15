//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct CmdScripts
    {
        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(CmdPattern pattern)
            => new CmdScriptExpr(pattern);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(in Paired<CmdPattern,CmdVarIndex> src)
            => new CmdScriptExpr(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(CmdPattern pattern, CmdVarIndex vars)
            => new CmdScriptExpr(pattern, vars);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdScriptExpr<K> expr<K>(CmdPattern pattern, CmdVarIndex<K> content)
            where K : unmanaged
                => new CmdScriptExpr<K>(pattern, content);

        [MethodImpl(Inline)]
        public static CmdScriptExpr<K,T> expr<K,T>(K id, T content)
            where K : unmanaged
                => new CmdScriptExpr<K,T>(id,content);
    }
}