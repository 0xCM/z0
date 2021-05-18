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
        public static CliToken token(EntityHandle src)
            => @as<EntityHandle,CliToken>(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(Handle src)
        {
            var _data = data(src);
            return new CliToken(_data.Table, _data.RowId);
        }
    }
}