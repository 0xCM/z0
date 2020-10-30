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
        public static CmdOptions options(params CmdOption[] src)
            => new CmdOptions(src);
    }
}