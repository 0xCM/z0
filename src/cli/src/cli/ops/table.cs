//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Root;

    partial struct Cli
    {
        [MethodImpl(Inline), Op]
        public static CliTableKind table(Handle handle)
            => data(handle).Table;
    }
}