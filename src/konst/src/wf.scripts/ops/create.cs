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
        /// <summary>
        /// Allocates a <see cref='CmdScript'/> of specified length
        /// </summary>
        /// <param name="length">The script length</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(string id, int length)
            => new CmdScript(id, alloc<CmdExpr>(length));

        /// <summary>
        /// Creates an anonymous <see cref='CmdScript'/> from a <see cref='CmdExpr'/> sequence
        /// </summary>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(params CmdExpr[] src)
            => new CmdScript(src);

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(string id, params CmdExpr[] src)
            => new CmdScript(id,src);

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript create(in asci32 id, params CmdExpr[] expr)
            => new CmdScript(id,expr);
    }
}