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
        /// <summary>
        /// Allocates a <see cref='CmdScript'/> of specified length
        /// </summary>
        /// <param name="length">The script length</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(string id, int length)
            => new CmdScript(id, alloc<CmdScriptExpr>(length));

        /// <summary>
        /// Creates an anonymous <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(params CmdScriptExpr[] src)
            => new CmdScript(src);

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(string id, params CmdScriptExpr[] src)
            => new CmdScript(id, src);

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(in asci32 id, params CmdScriptExpr[] expr)
            => new CmdScript(id,expr);
    }
}