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

    [ApiHost("tooling", true)]
    public partial struct Tooling
    {
        [MethodImpl(Inline)]
        public static ToolOption option<E,V>(E kind, V value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value.ToString());

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ToolFlag flag(string name)
            => name;
    }
}