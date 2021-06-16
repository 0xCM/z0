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

    using static Root;
    using static core;

    partial struct Cli
    {
        [MethodImpl(Inline), Op]
        public static CliHandleData data(Handle src)
            => @as<Handle,CliHandleData>(src);

        [MethodImpl(Inline), Op]
        public static CliHandleData data(EntityHandle src)
        {
            var row = uint32(src) & 0xFFFFFF;
            var kind = (CliTableKind)(uint32(src) >> 24);
            return new CliHandleData(kind,row);
        }
    }
}