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
        [MethodImpl(Inline)]
        public static CmdId id<T>()
            => CmdId.id(typeof(T));

        [MethodImpl(Inline), Op]
        public static CmdId id(Type spec)
            => CmdId.id(spec);

        [MethodImpl(Inline), Op]
        public static CmdId id(string src)
            => CmdId.id(src);
    }
}