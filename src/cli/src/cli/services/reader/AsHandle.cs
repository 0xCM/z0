//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static core;
    using static CliTableKinds;

    partial class CliReader
    {
        [MethodImpl(Inline), Op]
        public static CliHandleData data(Handle src)
            => @as<Handle,CliHandleData>(src);

        [MethodImpl(Inline), Op]
        public static CliHandleData data(EntityHandle src)
            => @as<EntityHandle ,CliHandleData>(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(EntityHandle src)
        {
            var _data = data(src);
            return new CliToken(_data.Table, _data.RowId);
        }

        [MethodImpl(Inline), Op]
        public Handle AsHandle(CliToken src)
            => @as<CliHandleData,Handle>(new CliHandleData(src.Table, src.Row));

        [MethodImpl(Inline), Op]
        public Handle AsHandle(CliHandleData src)
            => @as<CliHandleData,Handle>(src);

        [MethodImpl(Inline)]
        public T AsHandle<T>(CliRowKey src)
            => @as<CliHandleData,T>(new CliHandleData(src.Table, src.Row));
    }
}