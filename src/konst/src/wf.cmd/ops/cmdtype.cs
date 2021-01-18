//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Cmd
    {
        [Op]
        public static CmdTypeInfo cmdtype(Type src)
            => new CmdTypeInfo(src, src.DeclaredInstanceFields());

        public static CmdTypeInfo<T> cmdtype<T>()
            where T : struct, ICmd<T>
                => default;
    }
}