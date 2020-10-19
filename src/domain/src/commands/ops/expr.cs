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
        public static CmdExpr expr(string content)
            => new CmdExpr(content);

        [MethodImpl(Inline), Op]
        public static CmdExpr expr(string id, string content)
            => new CmdExpr(id, content);

        [MethodImpl(Inline), Op]
        public static CmdExpr expr(in asci32 id, string content)
            => new CmdExpr(id, content);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdExpr<T> expr<T>(string id, T content)
            => new CmdExpr<T>(id, content);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdExpr<T> expr<T>(in asci32 id, T content)
            => new CmdExpr<T>(id, content);

        [MethodImpl(Inline)]
        public static CmdExpr<K,T> expr<K,T>(K id, T content)
            where K : unmanaged
                => new CmdExpr<K,T>(id,content);
    }
}