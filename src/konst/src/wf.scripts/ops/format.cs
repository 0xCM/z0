//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct CmdScripts
    {
        [Op]
        public static string format(CmdScriptVar src)
            => string.Format("{0}={1}",src.Symbol, src.Value);

        [Op]
        public static string format(in CmdScript src)
        {
            var dst = Buffers.text();
            CmdScripts.render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static string format(in CmdScriptExpr src)
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static string format<K>(in CmdScriptExpr<K> src)
            where K : unmanaged
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static CmdScriptExpr format(in CmdPattern pattern, params CmdVar[] args)
            => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern<K> pattern, params CmdVar[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern pattern, params CmdVar<K>[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));
    }
}