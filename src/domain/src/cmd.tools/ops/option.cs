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

    partial struct Tooling
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolOption option<K>(K kind, string value)
            where K : unmanaged
                => new ToolOption(kind.ToString(), value);

        [MethodImpl(Inline), Op]
        public static ToolOption option(string name, string value)
            => new ToolOption(name, value);
    }
}