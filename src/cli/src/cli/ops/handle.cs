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
        public static Handle handle(CliHandleData src)
            => @as<CliHandleData,Handle>(src);

        [MethodImpl(Inline), Op]
        public Handle handle(CliToken src)
            => handle(new CliHandleData(src.Table, src.Row));


        [MethodImpl(Inline), Op]
        public static EntityHandle handle(uint src)
            => @as<uint,EntityHandle>(src);
    }
}