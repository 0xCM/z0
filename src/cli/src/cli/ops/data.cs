//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;

    partial struct Cli
    {
        [MethodImpl(Inline), Op]
        public static CliHandleData data(Handle src)
            => @as<Handle,CliHandleData>(src);
    }
}