//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdExpr expr(CmdPattern pattern)
            => new CmdExpr(pattern);

        [MethodImpl(Inline), Op]
        public static CmdExpr expr(in Paired<CmdPattern,CmdVars> src)
            => new CmdExpr(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public static CmdExpr expr(CmdPattern pattern, CmdVars vars)
            => new CmdExpr(pattern, vars);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdExpr<K> expr<K>(CmdPattern pattern, CmdVars<K> content)
            where K : unmanaged
                => new CmdExpr<K>(pattern, content);

        [MethodImpl(Inline)]
        public static CmdExpr<K,T> expr<K,T>(K id, T content)
            where K : unmanaged
                => new CmdExpr<K,T>(id,content);
    }
}