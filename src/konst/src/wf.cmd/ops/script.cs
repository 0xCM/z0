//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        /// <summary>
        /// Allocates a <see cref='CmdScript'/> of specified length
        /// </summary>
        /// <param name="length">The script length</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(string id, int length)
            => new CmdScript(id, sys.alloc<CmdScriptExpr>(length));

        /// <summary>
        /// Creates an anonymous <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(params CmdScriptExpr[] src)
            => new CmdScript(src);

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(string id, params CmdScriptExpr[] src)
            => new CmdScript(id, src);

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(in asci32 id, params CmdScriptExpr[] expr)
            => new CmdScript(id,expr);
    }
}