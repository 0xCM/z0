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
        /// <summary>
        /// Creates a <see cref='CmdOptions'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static CmdPattern pattern(string id, string spec)
            => new CmdPattern(id, spec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdPattern<K> pattern<K>(K id, string content)
            where K : unmanaged
                => new CmdPattern<K>(id,content);
    }
}