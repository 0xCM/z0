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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdId id<T>()
            => CmdId.from<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdId id<T>(T t)
            => CmdId.from<T>();

        [MethodImpl(Inline), Op]
        public static CmdId id(Type spec)
            => CmdId.from(spec);

        /// <summary>
        /// Parses a <see cref='CmdId'/> from a command identifier
        /// </summary>
        /// <param name="src">The command identifier</param>
        [MethodImpl(Inline), Op]
        public static CmdId id(string src)
            => new CmdId(src);
    }
}