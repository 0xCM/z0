//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection;
    using System.Reflection.PortableExecutable;
    using Microsoft.CodeAnalysis;

    using static Root;
    using static core;

    partial struct Cli
    {
        [MethodImpl(Inline), Op]
        public static CliRowKey key(Handle src)
        {
            var dat = data(src);
            return new CliRowKey(dat.Table, dat.RowId);
        }

        [MethodImpl(Inline), Op]
        public static CliRowKey key(EntityHandle src)
        {
            var dat = data(src);
            return new CliRowKey(dat.Table, dat.RowId);
        }

        [MethodImpl(Inline)]
        public static CliRowKey<K> key<K,T>(T handle, K k = default)
            where K : unmanaged, ICliTableKind<K>
            where T : unmanaged
                => uint32(handle);

    }
}