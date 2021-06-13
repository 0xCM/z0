//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static HexFormatSpecs;

    partial struct Hex
    {
        public static string format<T>(UpperCased @case, T value)
            where T : unmanaged
                => new string(render<T>(@case, value));
    }
}