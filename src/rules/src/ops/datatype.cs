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

    partial struct Rules
    {
        [MethodImpl(Inline), Op]
        public static DataType datatype(string name)
            => new DataType(name);
    }
}