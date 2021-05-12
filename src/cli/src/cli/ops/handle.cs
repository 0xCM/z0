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
        public static Handle handle(CliToken src)
            => @as<CliHandleData,Handle>(new CliHandleData(src.Table, src.Row));

        [MethodImpl(Inline), Op]
        public static Handle handle(CliHandleData src)
            => @as<CliHandleData,Handle>(src);

        [MethodImpl(Inline)]
        public static T handle<T>(CliRowKey src)
            => @as<CliHandleData,T>(new CliHandleData(src.Table, src.Row));
    }
}