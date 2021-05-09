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

        [MethodImpl(Inline)]
        public static CliHandleData data<K>(CliRowKey<K> src)
            where K : unmanaged, ICliTableKind<K>
                => new CliHandleData(src.Table, src.Row);

        [MethodImpl(Inline)]
        public static CliHandleData data(CliRowKey src)
            => new CliHandleData(src.Table, src.Row);
    }
}